
namespace Tyuiu.KoevaSJ.Sprint6.Task7.V24
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxTask_KSJ = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData_KSJ = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutData_KSJ = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KSJ = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_KSJ = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_KSJ = new System.Windows.Forms.ToolTip(this.components);
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.buttonAbout_KSJ = new System.Windows.Forms.Button();
            this.buttonSave_KSJ = new System.Windows.Forms.Button();
            this.buttonDone_KSJ = new System.Windows.Forms.Button();
            this.buttonOpenFile_KSJ = new System.Windows.Forms.Button();
            this.saveFileDialogMatrix_KSJ = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewIn_KSJ = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_KSJ = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxTask_KSJ.SuspendLayout();
            this.groupBoxOutPutData_KSJ.SuspendLayout();
            this.groupBoxInPutData_KSJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KSJ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAbout_KSJ);
            this.panel1.Controls.Add(this.buttonSave_KSJ);
            this.panel1.Controls.Add(this.buttonDone_KSJ);
            this.panel1.Controls.Add(this.buttonOpenFile_KSJ);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 133);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxOutPutData_KSJ);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 274);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 395);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask_KSJ);
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 129);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxInPutData_KSJ);
            this.panel3.Location = new System.Drawing.Point(624, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 380);
            this.panel3.TabIndex = 2;
            // 
            // groupBoxTask_KSJ
            // 
            this.groupBoxTask_KSJ.Controls.Add(this.splitter2);
            this.groupBoxTask_KSJ.Controls.Add(this.textBoxTask_KSJ);
            this.groupBoxTask_KSJ.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_KSJ.Name = "groupBoxTask_KSJ";
            this.groupBoxTask_KSJ.Size = new System.Drawing.Size(1257, 126);
            this.groupBoxTask_KSJ.TabIndex = 0;
            this.groupBoxTask_KSJ.TabStop = false;
            this.groupBoxTask_KSJ.Text = "Условие";
            // 
            // groupBoxOutPutData_KSJ
            // 
            this.groupBoxOutPutData_KSJ.Controls.Add(this.dataGridViewIn_KSJ);
            this.groupBoxOutPutData_KSJ.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOutPutData_KSJ.Name = "groupBoxOutPutData_KSJ";
            this.groupBoxOutPutData_KSJ.Size = new System.Drawing.Size(615, 377);
            this.groupBoxOutPutData_KSJ.TabIndex = 0;
            this.groupBoxOutPutData_KSJ.TabStop = false;
            this.groupBoxOutPutData_KSJ.Text = "Ввод:";
            // 
            // groupBoxInPutData_KSJ
            // 
            this.groupBoxInPutData_KSJ.Controls.Add(this.dataGridViewOut_KSJ);
            this.groupBoxInPutData_KSJ.Controls.Add(this.splitter1);
            this.groupBoxInPutData_KSJ.Location = new System.Drawing.Point(0, 3);
            this.groupBoxInPutData_KSJ.Name = "groupBoxInPutData_KSJ";
            this.groupBoxInPutData_KSJ.Size = new System.Drawing.Size(633, 374);
            this.groupBoxInPutData_KSJ.TabIndex = 0;
            this.groupBoxInPutData_KSJ.TabStop = false;
            this.groupBoxInPutData_KSJ.Text = "Вывод:";
            // 
            // textBoxTask_KSJ
            // 
            this.textBoxTask_KSJ.Location = new System.Drawing.Point(12, 30);
            this.textBoxTask_KSJ.Multiline = true;
            this.textBoxTask_KSJ.Name = "textBoxTask_KSJ";
            this.textBoxTask_KSJ.ReadOnly = true;
            this.textBoxTask_KSJ.Size = new System.Drawing.Size(1239, 90);
            this.textBoxTask_KSJ.TabIndex = 0;
            this.textBoxTask_KSJ.Text = resources.GetString("textBoxTask_KSJ.Text");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 27);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 344);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // openFileDialogTask_KSJ
            // 
            this.openFileDialogTask_KSJ.FileName = "openFileDialog1";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 27);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 96);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // buttonAbout_KSJ
            // 
            this.buttonAbout_KSJ.Image = global::Tyuiu.KoevaSJ.Sprint6.Task7.V24.Properties.Resources.help;
            this.buttonAbout_KSJ.Location = new System.Drawing.Point(1136, 28);
            this.buttonAbout_KSJ.Name = "buttonAbout_KSJ";
            this.buttonAbout_KSJ.Size = new System.Drawing.Size(130, 79);
            this.buttonAbout_KSJ.TabIndex = 3;
            this.toolTipButton_KSJ.SetToolTip(this.buttonAbout_KSJ, "Сведения о программе");
            this.buttonAbout_KSJ.UseVisualStyleBackColor = true;
            this.buttonAbout_KSJ.Click += new System.EventHandler(this.buttonAbout_KSJ_Click);
            this.buttonAbout_KSJ.MouseEnter += new System.EventHandler(this.buttonAbout_KSJ_MouseEnter);
            // 
            // buttonSave_KSJ
            // 
            this.buttonSave_KSJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_KSJ.Image = global::Tyuiu.KoevaSJ.Sprint6.Task7.V24.Properties.Resources.page_save;
            this.buttonSave_KSJ.Location = new System.Drawing.Point(375, 23);
            this.buttonSave_KSJ.Name = "buttonSave_KSJ";
            this.buttonSave_KSJ.Size = new System.Drawing.Size(147, 89);
            this.buttonSave_KSJ.TabIndex = 2;
            this.toolTipButton_KSJ.SetToolTip(this.buttonSave_KSJ, "Сохранить файл\r\nСохранить обработанные данные в файл в формате CSV");
            this.buttonSave_KSJ.UseVisualStyleBackColor = true;
            this.buttonSave_KSJ.Click += new System.EventHandler(this.buttonSave_KSJ_Click);
            this.buttonSave_KSJ.MouseEnter += new System.EventHandler(this.buttonSave_KSJ_MouseEnter);
            // 
            // buttonDone_KSJ
            // 
            this.buttonDone_KSJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_KSJ.Image = global::Tyuiu.KoevaSJ.Sprint6.Task7.V24.Properties.Resources.page_white_go;
            this.buttonDone_KSJ.Location = new System.Drawing.Point(205, 23);
            this.buttonDone_KSJ.Name = "buttonDone_KSJ";
            this.buttonDone_KSJ.Size = new System.Drawing.Size(137, 89);
            this.buttonDone_KSJ.TabIndex = 1;
            this.toolTipButton_KSJ.SetToolTip(this.buttonDone_KSJ, "Выполнить\r\nВыполнить обработку данных\r\n");
            this.buttonDone_KSJ.UseVisualStyleBackColor = true;
            this.buttonDone_KSJ.Click += new System.EventHandler(this.buttonDone_KSJ_Click);
            this.buttonDone_KSJ.MouseEnter += new System.EventHandler(this.buttonDone_KSJ_MouseEnter);
            // 
            // buttonOpenFile_KSJ
            // 
            this.buttonOpenFile_KSJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_KSJ.Image = global::Tyuiu.KoevaSJ.Sprint6.Task7.V24.Properties.Resources.folder_page;
            this.buttonOpenFile_KSJ.Location = new System.Drawing.Point(12, 23);
            this.buttonOpenFile_KSJ.Name = "buttonOpenFile_KSJ";
            this.buttonOpenFile_KSJ.Size = new System.Drawing.Size(159, 89);
            this.buttonOpenFile_KSJ.TabIndex = 0;
            this.toolTipButton_KSJ.SetToolTip(this.buttonOpenFile_KSJ, "Открыть файл\r\nОткрыть файл для обработки данных в формате СSV\r\n\r\n");
            this.buttonOpenFile_KSJ.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KSJ.Click += new System.EventHandler(this.buttonOpenFile_KSJ_Click);
            this.buttonOpenFile_KSJ.MouseEnter += new System.EventHandler(this.buttonOpenFile_SVV_MouseEnter);
            // 
            // dataGridViewIn_KSJ
            // 
            this.dataGridViewIn_KSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_KSJ.Location = new System.Drawing.Point(9, 43);
            this.dataGridViewIn_KSJ.Name = "dataGridViewIn_KSJ";
            this.dataGridViewIn_KSJ.RowHeadersWidth = 82;
            this.dataGridViewIn_KSJ.RowTemplate.Height = 33;
            this.dataGridViewIn_KSJ.Size = new System.Drawing.Size(600, 331);
            this.dataGridViewIn_KSJ.TabIndex = 4;
            // 
            // dataGridViewOut_KSJ
            // 
            this.dataGridViewOut_KSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_KSJ.Location = new System.Drawing.Point(11, 35);
            this.dataGridViewOut_KSJ.Name = "dataGridViewOut_KSJ";
            this.dataGridViewOut_KSJ.RowHeadersWidth = 82;
            this.dataGridViewOut_KSJ.RowTemplate.Height = 33;
            this.dataGridViewOut_KSJ.Size = new System.Drawing.Size(616, 336);
            this.dataGridViewOut_KSJ.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 666);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 24 | Коева С.Ю";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBoxTask_KSJ.ResumeLayout(false);
            this.groupBoxTask_KSJ.PerformLayout();
            this.groupBoxOutPutData_KSJ.ResumeLayout(false);
            this.groupBoxInPutData_KSJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KSJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAbout_KSJ;
        private System.Windows.Forms.Button buttonSave_KSJ;
        private System.Windows.Forms.Button buttonDone_KSJ;
        private System.Windows.Forms.Button buttonOpenFile_KSJ;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_KSJ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxTask_KSJ;
        private System.Windows.Forms.TextBox textBoxTask_KSJ;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxInPutData_KSJ;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KSJ;
        private System.Windows.Forms.ToolTip toolTipButton_KSJ;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KSJ;
        private System.Windows.Forms.DataGridView dataGridViewIn_KSJ;
        private System.Windows.Forms.DataGridView dataGridViewOut_KSJ;
    }
}

