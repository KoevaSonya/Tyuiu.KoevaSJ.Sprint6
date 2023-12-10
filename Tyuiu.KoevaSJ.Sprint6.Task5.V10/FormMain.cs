using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.KoevaSJ.Sprint6.Task5.V10.Lib;


namespace Tyuiu.KoevaSJ.Sprint6.Task5.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V10.txt";

        private void buttonHelp_KSJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы АСОиУб-23-1 Коева Софья Юрьевна", "Сообщение");
        }

        private void buttonDone_KSJ_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KSJ.ColumnCount = 2;
            dataGridViewResult_KSJ.Columns[0].Width = 20;
            dataGridViewResult_KSJ.Columns[1].Width = 50;

            this.chartFunction_KSJ.ChartAreas[0].AxisX.Title = " Ось X";
            this.chartFunction_KSJ.ChartAreas[0].AxisY.Title = " Ось Y";

            chartFunction_KSJ.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_KSJ.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_KSJ.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_KSJ_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
