using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Simplifier
{
    public enum PointType { Source = 0, Result1, Result2, Polinom, AbsSource, FindPoints1, FindPoints2 }
    public enum DataType { Current = 0, Potential, Time, Index }

    class Point
    {
        public Double[] Values { get; private set; }
        
        public Point(String rawLine, Int32 index, Int32 inputType)
        {
            Values = new Double[4];
            String[] lines;
            switch (inputType)
            {
                case 1:
                    rawLine = rawLine.Replace("    ", "|");
                    lines = rawLine.Split('|');
                    try
                    {
                        Values[0] = Double.Parse(lines[1]); //Current
                        Values[1] = Double.Parse(lines[2]); //Potental
                        Values[2] = Double.Parse(lines[0]); //Time
                        Values[3] = index;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error reading data on point creation! *dat", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    break;
                case 2:
                    rawLine = rawLine.Replace(".", ",");
                    lines = rawLine.Split(';');
                    try
                    {
                        Values[0] = Double.Parse(lines[1]); //Current
                        Values[1] = Double.Parse(lines[2]); //Potental
                        Values[2] = Double.Parse(lines[0]); //Time
                        Values[3] = index;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error reading data on point creation!", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    break;
                default:
                    break;
            }
            
        }

        public Point(Double[] values)
        {
            this.Values = new Double[4];
            for (int i = 0; i < 4; i++)
            {
                this.Values[i] = values[i];
            }
        }

        public Point(Point old)
        {
            Values = new Double[4];
            for (int i = 0; i < 4; i++)
            {
                this.Values[i] = old.Values[i];
            }
        }

        public void ToAbs()
        {
            for (int i = 0; i < Values.Length; i++)
            {
                if(Values[i] < 0)
                    Values[i] = Values[i]*-1;
            }
                
        }
    }

    internal class OpenedFile
    {
        public List<List<Point>> points { get; private set; }

        public OpenedFile()
        {
            points = new List<List<Point>>();
            for (int i = 0; i < 7; i++)
            {
                points.Add(new List<Point>());
            }
        }

        public bool LoadData(String fileName, Int32 fileType)
        {
            try
            {
                points[(Int32)PointType.Source] = new List<Point>();
                StreamReader opFile = new StreamReader(fileName);
                String line;
                Int32 index = 0;
                line = opFile.ReadLine();
                if (fileType == 2)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if(Char.IsLetter(line[i]))
                            line = opFile.ReadLine();
                    }
                }
                do
                {
                    points[(Int32)PointType.Source].Add(new Point(line, index, fileType));
                    index++;
                }
                while ((line = opFile.ReadLine()) != null);
            }
            catch (Exception)
            {
                MessageBox.Show("Error reading data on list creation!", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public Double[] GetArray(PointType type, DataType axis)
        {
            if (points[(Int32)type].Count < 1) return null;
            Double[] result = new Double[points[(int)type].Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = points[(int)type][i].Values[(Int32)axis];
            }
            return result;
        }

        public Double[] FindPolynom(Int32 power, DataType x_axis, DataType y_axis, PointType apprData)
        {
            if (points[0].Count < 0) return null;
            points[3] = new List<Point>();
            points[4] = new List<Point>();
            for (int i = 0; i < points[0].Count; i++)
            {
                points[4].Add(new Point(points[0][i]));
                points[4][i].ToAbs();
            }
            Double[] ploCoef = CreatePolynomMatrix(points[4], power, x_axis, y_axis);
            Double[] val = new Double[4];
            Double minX, maxX;  
            Int32 a;
            FindMinMaxValue(points[(Int32)apprData], x_axis, out maxX, out a, out minX, out a);
            Double step = (maxX - minX) / 100;
            for (int i = 0; i < 100; i++)
            {
                val[(int)y_axis] = 0;
                val[(int)x_axis] = minX + i * step;
                val[3] = i;
                for (int j = 0; j < ploCoef.Length; j++)
                    val[(int)y_axis] = val[(int)y_axis] + ploCoef[j] * Power(val[(int)x_axis], j);
                points[3].Add(new Point(val));
            }
            return ploCoef;
        }

        public void SliceGraphics(Double[] polynom, Double delta, Int32 shift, DataType x_axis, DataType y_axis)
        {
            Double temp = 0;
            points[(Int32)PointType.Result1] = new List<Point>();
            points[(Int32)PointType.Result2] = new List<Point>();
            points[(Int32)PointType.FindPoints1] = new List<Point>();
            points[(Int32)PointType.FindPoints2] = new List<Point>();
            Int32 flag = 0;

            for (int i = 0; i < points[(Int32)PointType.AbsSource].Count; i++)
            {
                temp = 0;
                for (int j = 0; j < polynom.Length; j++)
                    temp += polynom[j] * Power(points[(Int32)PointType.AbsSource][i].Values[(int)x_axis], j);
                if (points[(Int32)PointType.AbsSource][i].Values[(int)y_axis] > temp)
                {
                    if (Math.Abs(points[(Int32)PointType.AbsSource][i].Values[(int)y_axis] - temp) > delta)
                    {
                        points[(Int32)PointType.Result1].Add(new Point(points[(Int32)PointType.Source][i]));
                        if (flag != 1)
                        {
                            if(i - shift>0)
                                points[(Int32)PointType.FindPoints1].Add(new Point(points[(Int32)PointType.Source][i - shift]));
                            else
                                points[(Int32)PointType.FindPoints1].Add(new Point(points[(Int32)PointType.Source][0]));
                        }
                            
                        flag = 1;
                    }

                }
                else
                {
                    if (Math.Abs(points[(Int32)PointType.AbsSource][i].Values[(int)y_axis] - temp) > delta)
                    {
                        points[(Int32)PointType.Result2].Add(new Point(points[(Int32)PointType.Source][i]));
                        if (flag != 2)
                        {
                            if (i - shift > 0)
                                points[(Int32)PointType.FindPoints2].Add(new Point(points[(Int32)PointType.Source][i - shift]));
                            else
                                points[(Int32)PointType.FindPoints2].Add(new Point(points[(Int32)PointType.Source][0]));
                        }
                        flag = 2;
                    }
                        
                }
            }
        }

        static Double Power(Double val, Int32 power)
        {
            if (power == 0) return 1.0;
            Double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= val;
            }
            return result;
        }

        Double[] CreatePolynomMatrix(List<Point> data, Int32 power, DataType x_axis, DataType y_axis)
        {
            Double[,] basic = new Double[data.Count, power + 1];
            for (int i = 0; i < basic.GetLength(0); i++)
                for (int j = 0; j < basic.GetLength(1); j++)
                    basic[i,j] = Math.Pow(data[i].Values[(Int32)x_axis], j);
            Matrix basicFuncMatr = new Matrix(basic);
            Matrix transBasicFuncMatr = basicFuncMatr.Transposition();
            Matrix lambda = transBasicFuncMatr * basicFuncMatr;
            Double[] Y = new Double[data.Count];
            for (int i = 0; i < data.Count; i++)
            {
                Y[i] = data[i].Values[(Int32)y_axis];
            }
            Matrix beta = transBasicFuncMatr * new Matrix(Y);
            Matrix a = lambda.InverseMatrix() * beta;
            Double[] coeff = new Double[a.Row];
            for (int i = 0; i < a.Row; i++)
                coeff[i] = a.Args[i, 0];
            return coeff;
        }

        void FindMinMaxValue(List<Point> arr, DataType type, out Double maxValue, out Int32 indexMax, out Double minValue, out Int32 indexMin)
        {
            indexMax = -1;
            indexMin = -1;
            maxValue = arr[0].Values[(Int32)type];
            minValue = arr[0].Values[(Int32)type];
            for (int i = 0; i < arr.Count; i++)
            {
                if (maxValue < arr[i].Values[(Int32)type])
                {
                    maxValue = arr[i].Values[(Int32)type];
                    indexMax = i;
                }
                if (minValue > arr[i].Values[(Int32)type])
                {
                    minValue = arr[i].Values[(Int32)type];
                    indexMin = i;
                }
            }
        }

        //Depricated
        public System.Drawing.PointF[] ConvertToDisplay(PointType type, DataType x_axis, DataType y_axis, params Double[] val)
        {
            if (points[(int)type].Count < 1) return null;
            var result = new System.Drawing.PointF[points[(int)type].Count];
            Double k = 0;
            Double xShift = val[1];
            Double yShift = val[3];
            Double maxValue, minValue;
            Int32 a;
            FindMinMaxValue(points[(int)type], x_axis, out maxValue, out a, out minValue, out a);
            if ((maxValue - minValue) != 0)
                k = val[0] / (maxValue - minValue);
            if (minValue < 0)
                xShift -= minValue;
            else
                xShift += minValue;
            for (int i = 0; i < result.Length; i++)
                result[i].X = (float)(points[(int)type][i].Values[(Int32)x_axis] * k + xShift);

            FindMinMaxValue(points[(int)type], y_axis, out maxValue, out a, out minValue, out a);
            if ((maxValue - minValue) != 0)
                k = val[2] / (maxValue - minValue);
            if (minValue < 0)
                yShift -= minValue;
            else
                yShift += minValue;

            for (int i = 0; i < result.Length; i++)
                result[i].Y = (float)(points[(int)type][i].Values[(Int32)y_axis] * k + yShift);

            return result;
        }

        //Legacy
        Double[] CreatePolynom(List<Point> data, Int32 power, DataType x_axis, DataType y_axis)
        {
            //Allocate memory for calculating
            Double[] a = new Double[power + 1];
            Double[] b = new Double[power + 1];
            Double[,] sums = new Double[power + 1, power + 1];
            //init square sum matrix
            for (int i = 0; i < power + 1; i++)
            {
                for (int j = 0; j < power + 1; j++)
                {
                    sums[i, j] = 0d;
                    for (int k = 0; k < data.Count; k++)
                    {
                        sums[i, j] += Math.Pow(data[k].Values[(Int32)x_axis], i + j);
                    }
                }
            }
            //init free coef column
            for (int i = 0; i < power + 1; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    b[i] += Math.Pow(data[j].Values[(Int32)x_axis], i) + data[j].Values[(Int32)y_axis];
                }
            }
            //check for 0 in diagonal 
            double temp = 0, M = 0;
            for (int i = 0; i < power + 1; i++)
            {
                if (sums[i, i] == 0.0)
                {
                    for (int j = 0; j < power+1; j++)
                    {
                        if (j == i) continue;
                        if (sums[i, j] != 0 && sums[j, i] != 0)
                        {
                            for (int k = 0; k < power+1; k++)
                            {
                                temp = sums[j, k];
                                sums[j, k] = sums[i, k];
                                sums[i, k] = temp;
                            }
                            temp = b[j];
                            b[j] = b[i];
                            b[i] = temp;
                            break;
                        }
                    }
                }
            }
            //proccess rows
            for (int k = 0; k < power+1; k++)
            {
                for (int i = k+1; i < power+1; i++)
                {
                    if (sums[k, k] == 0) return null;
                    M = sums[i, k] / sums[k, k];
                    for (int j = k; j < power + 1; j++)
                        sums[i, j] -= M * sums[k, j];
                    b[i] -= M * b[k];
                }
            }
            //calculate result matrix
            for (int i = power; i >= 0; i--)
            {
                Double s = 0;
                for (int j = i; j < power+1; j++)
                {
                    s = s + sums[i, j] * a[j];
                }
                a[i] = (b[i] - s) / sums[i, i];
            }
            return a;
        }
        
    }
}

