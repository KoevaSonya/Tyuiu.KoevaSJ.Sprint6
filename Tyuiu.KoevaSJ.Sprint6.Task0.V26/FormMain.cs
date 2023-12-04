using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KoevaSJ.Sprint6.Task0.V26.Lib;

namespace Tyuiu.KoevaSJ.Sprint6.Task0.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

       

       

        

        private void textBoxVarX_KSJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxVarX_KSJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_KSJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы АСОиУб-23-1 Коева Софья Юрьевна", "Сообщение");
        }

        private void buttonDone_KSJ_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KSJ.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KSJ.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
