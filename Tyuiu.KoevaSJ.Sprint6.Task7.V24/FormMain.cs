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

using Tyuiu.KoevaSJ.Sprint6.Task7.V24.Lib;

namespace Tyuiu.KoevaSJ.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
           
            openFileDialogTask_KSJ.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KSJ.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|(*.*)";
        }


        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }



        private void buttonOpenFile_KSJ_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KSJ.ShowDialog();
            openFilePath = openFileDialogTask_KSJ.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KSJ.ColumnCount = columns;
            dataGridViewIn_KSJ.RowCount = rows;
            dataGridViewOut_KSJ.ColumnCount = columns;
            dataGridViewOut_KSJ.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KSJ.Columns[i].Width = 25;
                dataGridViewOut_KSJ.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_KSJ.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KSJ.Enabled = true;
        }

        private void buttonDone_KSJ_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KSJ.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_KSJ.Enabled = true;
        }

        private void buttonSave_KSJ_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KSJ.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KSJ.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KSJ.ShowDialog();

            string path = saveFileDialogMatrix_KSJ.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_KSJ.RowCount;
            int columns = dataGridViewOut_KSJ.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KSJ.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KSJ.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAbout_KSJ_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KSJ.ToolTipTitle = "Открыть файл";
        }

        private void buttonAbout_KSJ_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KSJ.ToolTipTitle = "Справка";
        }

        private void buttonDone_KSJ_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KSJ.ToolTipTitle = "Выполнить";

        }

        private void buttonSave_KSJ_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KSJ.ToolTipTitle = "Сохранить";
        }
    }
}
