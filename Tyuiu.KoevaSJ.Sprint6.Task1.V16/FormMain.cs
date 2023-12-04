using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KoevaSJ.Sprint6.Task1.V16.Lib;

namespace Tyuiu.KoevaSJ.Sprint6.Task1.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void buttonHelp_KSJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы АСОиУб-23-1 Коева Софья Юрьевна", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxVarStartStep_KDR_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonDone_KSJ_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_KSJ.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_KSJ.Text);
                string strLine;
                int step = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray = new double[step];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_KSJ.Text = "";
                textBoxResult_KSJ.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KSJ.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_KSJ.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= step - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_KSJ.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_KSJ.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
