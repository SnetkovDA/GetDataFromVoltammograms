using System;
using System.ComponentModel;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Simplifier
{
    public partial class Form1 : Form
    {
        OpenedFile currOpenedFile;
        Double[] polynom;
        String defName;

        DataType x_axis;
        DataType y_axis;
        PointType plotType;
        PointType saveType;
        PointType tableType;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currOpenedFile = new OpenedFile();
            x_axis = DataType.Potential;
            XaxisLabel.Text = "E";
            y_axis = DataType.Current;
            yAxesLabel.Text = "I";
            saveType = PointType.Source;
            tableType = PointType.Source;
            defName = this.Text;

            mainPlot.ChartAreas[0].CursorY.IsUserEnabled = true;
            mainPlot.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            mainPlot.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            mainPlot.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            mainPlot.ChartAreas[0].CursorX.IsUserEnabled = true;
            mainPlot.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            mainPlot.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            mainPlot.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            dataView.ColumnCount = 2;
            dataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataView.ColumnHeadersDefaultCellStyle.Font = new Font(dataView.Font, FontStyle.Bold);
            dataView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataView.GridColor = Color.Black;
            dataView.RowHeadersVisible = false;
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.MultiSelect = false;
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
                findPointBut.Enabled = true;
                dataView.Enabled = true;
                this.Text = defName + " [" + ofd1.FileName + "]";
            }
            plotType = PointType.Source;
            Drawing(true);
            tableType = PointType.Source;
            DisplayResults();
            
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

        void DisplayResults()
        {
            Double[] xVals = currOpenedFile.GetArray(tableType, x_axis);
            Double[] yVals = currOpenedFile.GetArray(tableType, y_axis);
            if (xVals == null) return;
            if (yVals == null) return;
            dataView.Rows.Clear();
            dataView.Name = "Gr1";
            dataView.Columns[0].HeaderText = x_axis.ToString();
            dataView.Columns[1].HeaderText = y_axis.ToString();
            for (int i = 0; i < xVals.Length; i++)
            {
                dataView.Rows.Add(xVals[i], yVals[i]);
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

        private void findPointsButtom_Click(object sender, EventArgs e)
        {
            if (currOpenedFile.points[(Int32)PointType.Source].Count < 1) return;
            polynom = currOpenedFile.FindPolynom((Int32)powerVal.Value, DataType.Potential, DataType.Current, PointType.Source);
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
                if(i != 0)
                    sb.Append("+");
            }
            if (leng > 0)
                sb.Append("...");
            polynomLabel.Text = sb.ToString();
            plotType = PointType.Source;
            Drawing(true);
            plotType = PointType.Polinom;
            Drawing(false);
            currOpenedFile.SliceGraphics(polynom, (Double)deltaValue.Value, (Int32)shiftAfterLast.Value, inverseDirection.Checked, DataType.Potential, DataType.Current);
            tableType = PointType.FindPoints1;
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
            DisplayResults();
        }

        private void dataView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count < 1) return;
            Int32 i = dataView.SelectedRows[0].Index;
            if (i > currOpenedFile.points[(Int32)tableType].Count-1)
                i = currOpenedFile.points[(Int32)tableType].Count - 1;
            mainPlot.Series[(Int32)PointType.SelectedPoint].Points.Clear();
            mainPlot.Series[(Int32)PointType.SelectedPoint].Points.AddXY(currOpenedFile.points[(Int32)tableType][i].Values[(Int32)x_axis], currOpenedFile.points[(Int32)tableType][i].Values[(Int32)y_axis]);
        }

        private void displTableFindPoints1_Click(object sender, EventArgs e)
        {
            tableType = PointType.FindPoints1;
            DisplayResults();
        }

        private void displTableFindPoints2_Click(object sender, EventArgs e)
        {
            tableType = PointType.FindPoints2;
            DisplayResults();
        }

        private void removeTableButt_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count < 1 || dataView.SelectedRows[0].Index > currOpenedFile.points[(Int32)tableType].Count - 1) return;
            Int32 i = dataView.SelectedRows[0].Index;
            currOpenedFile.points[(Int32)tableType].RemoveAt(i);
            displayCalculatedPlot_Click(sender, e);
        }
        
        private void saveScreenShoot_Click(object sender, EventArgs e)
        {
            if (currOpenedFile.points[(Int32)PointType.Source].Count < 1) return;
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.Filter = "Plot image|*.png";
            sfd1.Title = "Save plot image:";
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                Stream sw = sfd1.OpenFile();
                mainPlot.SaveImage(sw, System.Drawing.Imaging.ImageFormat.Png);
                sw.Close();
                consoleOut.Text = "Success saving image.";
            }
        }

        private void displTableSource_Click(object sender, EventArgs e)
        {
            tableType = PointType.Source;
            DisplayResults();
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Get data from Voltammograms.\n Version: 1.2.2.0\n Developed by: Snetkov Dmitriy\n License: MIT License", "About window", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                return;
        }

        private void gitHubButtom_Click(object sender, EventArgs e)
        {
            string target = "https://snetkovda.github.io/GetDataFromVoltammograms/";
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void closeButDropList_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
