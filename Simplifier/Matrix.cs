using System;

namespace Simplifier
{
    class Matrix
    {
        public double[,] Args { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }

        public Matrix(double[] x)
        {
            Row = x.Length;
            Col = 1;
            Args = new double[Row, Col];
            for (int i = 0; i < Args.GetLength(0); i++)
                for (int j = 0; j < Args.GetLength(1); j++)
                    Args[i, j] = x[i];
        }

        public Matrix(double[,] x)
        {
            Row = x.GetLength(0);
            Col = x.GetLength(1);
            Args = new double[Row, Col];
            for (int i = 0; i < Args.GetLength(0); i++)
                for (int j = 0; j < Args.GetLength(1); j++)
                    Args[i, j] = x[i, j];
        }

        public Matrix(Matrix other)
        {
            this.Row = other.Row;
            this.Col = other.Col;
            Args = new double[Row, Col];
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Col; j++)
                    this.Args[i, j] = other.Args[i, j];
        }
        
        public Matrix Transposition()
        {
            double[,] t = new double[Col, Row];
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Col; j++)
                    t[j, i] = Args[i, j];
            return new Matrix(t);
        }

        public static Matrix operator *(Matrix m, double k)
        {
            Matrix ans = new Matrix(m);
            for (int i = 0; i < ans.Row; i++)
                for (int j = 0; j < ans.Col; j++)
                    ans.Args[i, j] = m.Args[i, j] * k;
            return ans;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Col != m2.Row) throw new ArgumentException("Multiplication of these two matrices can't be done!");
            double[,] ans = new double[m1.Row, m2.Col];
            for (int i = 0; i < m1.Row; i++)
            {
                for (int j = 0; j < m2.Col; j++)
                {
                    for (int k = 0; k < m2.Row; k++)
                    {
                        ans[i, j] += m1.Args[i, k] * m2.Args[k, j];
                    }
                }
            }
            return new Matrix(ans);
        }

        private Matrix getMinor(int row, int column)
        {
            if (Row != Col) throw new ArgumentException("Matrix should be square!");
            double[,] minor = new double[Row - 1, Col - 1];
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    if ((i != row) || (j != column))
                    {
                        if (i > row && j < column) minor[i - 1, j] = this.Args[i, j];
                        if (i < row && j > column) minor[i, j - 1] = this.Args[i, j];
                        if (i > row && j > column) minor[i - 1, j - 1] = this.Args[i, j];
                        if (i < row && j < column) minor[i, j] = this.Args[i, j];
                    }
                }
            }
            return new Matrix(minor);
        }

        public static double Determ(Matrix m)
        {
            if (m.Row != m.Col) throw new ArgumentException("Matrix should be square!");
            double det = 1;
            /*
            int length = m.Row;
            if (length == 1) det = m.Args[0, 0];
            if (length == 2) det = m.Args[0, 0] * m.Args[1, 1] - m.Args[0, 1] * m.Args[1, 0];
            if (length > 2)
                for (int i = 0; i < m.Col; i++)
                    det += Math.Pow(-1, 0 + i) * m.Args[0, i] * Determ(m.getMinor(0, i));
            */
            Matrix m1 = Trangalize(m, out Int32 swapOper);
            for (int i = 0; i < m1.Col; i++)
            {
                det *= m1.Args[i, i];
            }
            det *= Math.Pow(-1, swapOper);
            return det;
        }

        public Matrix MinorMatrix()
        {
            double[,] ans = new double[Row, Col];
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Col; j++)
                    ans[i, j] = Math.Pow(-1, i + j) * Determ(this.getMinor(i, j));
            return new Matrix(ans);
        }

        public Matrix InverseMatrix()
        {
            if (Math.Abs(Determ(this)) <= 0.000000001) throw new ArgumentException("Inverse matrix does not exist!");
            double k = 1 / Determ(this);
            Matrix minorMatrix = this.MinorMatrix();
            return minorMatrix * k;
        }

        public static Matrix Trangalize(Matrix m, out Int32 swapOper)
        {
            //конечная матрица, созданная копированием исходной
            Matrix res = new Matrix(m);
            swapOper = 0;
            Int32 _t = 0;//временная перемаенная, хранящая индекс макисмального числа в столбце
            Double _v = 0;//временная перемнная, хранящая макисмальное число в столбце
            for (int i = 0; i < res.Col; ++i)
            {
                //нахождение максимального числа в столбце
                for (int j = i; j < res.Col; ++j)
                {
                    if (Math.Abs(res.Args[j, i]) >= _v)
                    {
                        _t = j;
                        _v = res.Args[j, i];
                    }
                }
                //если самый левый столбец сейчас содержит не самое большое число, то меняем
                if (_t > i)
                {
                    res = SwapRows(res, i, _t);//меняет местами i и j строку
                    swapOper++;
                }
                //расчёт
                for (int j = i + 1; j < res.Col; ++j)
                {
                    //Если диагональный элмент матрицы не равен 0, то тогда считаем
                    if (res.Args[i, i] != 0)
                    {
                        _v = -res.Args[j, i] / res.Args[i, i];
                        for (int k = i; k < res.Row; ++k)
                        {
                            res.Args[j, k] += (res.Args[i, k] * _v);
                        }
                    }
                }
                //обнуление перемнных
                _v = Double.MinValue;
                _t = 0;
            }
            return res;
        }

        public static Matrix SwapRows(Matrix m, Int32 n, Int32 b)
        {
            Matrix res = new Matrix(m);
            for (int i = 0; i < m.Row; i++)
            {
                res.Args[b, i] = m.Args[n, i];
                res.Args[n, i] = m.Args[b, i];
            }
            return res;
        }
    }
}

