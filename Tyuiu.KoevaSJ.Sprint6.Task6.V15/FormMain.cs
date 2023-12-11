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
using Tyuiu.KoevaSJ.Sprint6.Task6.V15.Lib;

namespace Tyuiu.KoevaSJ.Sprint6.Task6.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;

        

        private void buttonOpenFile_KSJ_Click(object sender, EventArgs e)
        {
            openFileDialog_KSJ.ShowDialog();
            openFilePath = openFileDialog_KSJ.FileName;
            textBoxInPutData_KSJ.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_KSJ.Text = groupBoxOutPutData_KSJ.Text + " " + openFileDialog_KSJ.FileName;
            buttonDone_KSJ.Enabled = true;
        }



        private void buttonDone_KSJ_Click(object sender, EventArgs e)
        {
            textBoxOutPutData_KSJ.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_KSJ_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
