using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Simplifier
{
    public partial class Form1 : Form
    {
        OpenedFile currOpenedFile;
        Graphics gr;
        Pen p;
        Double[] polynom;

        DataType x_axis;
        DataType y_axis;
        PointType plotType;
        PointType saveType;

        public Form1()
        {
            InitializeComponent();
            gr = grapficsOut.CreateGraphics();
            p = new Pen(Color.Green, 1.0f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currOpenedFile = new OpenedFile();
            x_axis = DataType.Potential;
            XaxisLabel.Text = "E";
            y_axis = DataType.Current;
            yAxesLabel.Text = "I";
            saveType = PointType.AbsSource;

            mainPlot.ChartAreas[0].CursorY.IsUserEnabled = true;
            mainPlot.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            mainPlot.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            mainPlot.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            mainPlot.ChartAreas[0].CursorX.IsUserEnabled = true;
            mainPlot.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            mainPlot.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            mainPlot.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            
        }

        private void openButDropList_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "Data files|*.dat|Saved data|*.csv";
            ofd1.Title = "Select a data file";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                currOpenedFile.LoadData(ofd1.FileName, ofd1.FilterIndex);
                consoleOut.Text = "Success reading file";
            }
            plotType = PointType.Source;
            Drawing(true);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveButDropList_Click(object sender, EventArgs e)
        {
            if (currOpenedFile.points[(Int32)PointType.Source].Count < 1) return;
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.Filter = "Source data|*.csv|Result1 data|*.csv|Result2 data|*.csv|Polynom|*.csv|Absolute source|*.csv|Final points1|*.csv|Final points2|*.csv";
            sfd1.Title = "Save data:";
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                saveType = (PointType)sfd1.FilterIndex-1;
                if (currOpenedFile.points[(Int32)saveType].Count < 1) { consoleOut.Text = "No data to save."; return; }
                StreamWriter sw = new StreamWriter(sfd1.OpenFile());
                sw.WriteLine("Time;Current;Potential");
                for (int i = 0; i < currOpenedFile.points[(Int32)saveType].Count; i++)
                {
                    sw.WriteLine(   
                                    String.Format("{0};{1};{2}",
                                    currOpenedFile.points[(Int32)saveType][i].Values[2],
                                    currOpenedFile.points[(Int32)saveType][i].Values[0],
                                    currOpenedFile.points[(Int32)saveType][i].Values[1])
                                   );
                }
                sw.Close();
                consoleOut.Text = "Success saving file.";
            }
        }

        private void iTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plotType = PointType.Source;
            Drawing(true);
            plotType = PointType.Result1;
            Drawing(false);
            plotType = PointType.Result2;
            Drawing(false);
        }

        private void displayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plotType = PointType.Source;
            Drawing(true);
        }

        private void Drawing(bool clear)
        {
            if (clear)
            {
                for (int i = 0; i < mainPlot.Series.Count; i++)
                {
                    mainPlot.Series[i].Points.Clear();
                }
            }
            else
                mainPlot.Series[(Int32)plotType].Points.Clear();
            Double[] xVals = currOpenedFile.GetArray(plotType, x_axis);
            Double[] yVals = currOpenedFile.GetArray(plotType, y_axis);
            if (xVals == null) return;
            if (yVals == null) return;
            for (int i = 0; i < xVals.Length; i++)
            {
                mainPlot.Series[(Int32)plotType].Points.AddXY(xVals[i], yVals[i]);
            }
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x_axis = DataType.Current;
            XaxisLabel.Text = "I";
            Drawing(true);
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x_axis = DataType.Potential;
            XaxisLabel.Text = "E";
            Drawing(true);
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x_axis = DataType.Time;
            XaxisLabel.Text = "T";
            Drawing(true);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            y_axis = DataType.Current;
            yAxesLabel.Text = "I";
            Drawing(true);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            y_axis = DataType.Potential;
            yAxesLabel.Text = "E";
            Drawing(true);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            y_axis = DataType.Time;
            yAxesLabel.Text = "T";
            Drawing(true);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void findPointsButtom_Click(object sender, EventArgs e)
        {
            if (currOpenedFile.points[(Int32)PointType.Source].Count < 1) return;
            polynom = currOpenedFile.FindPolynom((Int32)powerVal.Value, DataType.Potential, DataType.Current, PointType.AbsSource);
            StringBuilder sb = new StringBuilder();
            Int32 leng = polynom.Length - 1;
            if (leng > 3)
                leng = polynom.Length - 3;
            else
                leng = 0;
            for (int i = polynom.Length - 1; i >= leng; i--)
            {
                sb.Append(polynom[i]);
                sb.Append("*x^");
                sb.Append(i);
                sb.Append(" ");
            }
            if (leng > 0)
                sb.Append("...");
            polynomLabel.Text = sb.ToString();
            plotType = PointType.AbsSource;
            Drawing(true);
            plotType = PointType.Polinom;
            Drawing(false);
            currOpenedFile.SliceGraphics(polynom, (Double)deltaValue.Value, (Int32)shiftAfterLast.Value, DataType.Potential, DataType.Current);
            
        }

        private void displayCalculatedPlot_Click(object sender, EventArgs e)
        {
            plotType = PointType.Result1;
            Drawing(true);
            plotType = PointType.Result2;
            Drawing(false);
            plotType = PointType.FindPoints1;
            Drawing(false);
            plotType = PointType.FindPoints2;
            Drawing(false);
        }
    }
    
}
