using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KoevaSJ.Sprint6.Task2.V17.Lib;

namespace Tyuiu.KoevaSJ.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelStartStep_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_KSJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы АСОиУБ-23-1 Коева Софья Юрьевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KSJ_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KSJ.Text);
                int endStep = Convert.ToInt32(textBoxStopStep_KSJ.Text);


                int len = ds.GetMassFunction(startStep, endStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, endStep);

                this.chartFunction_KSJ.Titles.Add("График функции f(x)");

                this.chartFunction_KSJ.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_KSJ.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KSJ.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_KSJ.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_KSJ_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KSJ.BackColor = Color.Red;
        }

        private void buttonDone_KSJ_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KSJ.BackColor = Color.Gold;
        }

        private void buttonDone_KSJ_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KSJ.BackColor = Color.Blue;
        }
    }
}







    
