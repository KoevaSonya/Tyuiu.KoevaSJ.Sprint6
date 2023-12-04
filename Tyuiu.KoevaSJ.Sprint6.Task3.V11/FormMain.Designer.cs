
namespace Tyuiu.KoevaSJ.Sprint6.Task3.V11
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
            this.groupBoxTask_KSJ = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxTask_KSJ = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KSJ = new System.Windows.Forms.GroupBox();
            this.labelResult_KSJ = new System.Windows.Forms.Label();
            this.dataGridViewResult_KSJ = new System.Windows.Forms.DataGridView();
            this.dataGridViewTaskMatrix_KSJ = new System.Windows.Forms.DataGridView();
            this.buttonHelp_KSJ = new System.Windows.Forms.Button();
            this.buttonDone_KSJ = new System.Windows.Forms.Button();
            this.groupBoxTask_KSJ.SuspendLayout();
            this.groupBoxResult_KSJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_KSJ)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KSJ
            // 
            this.groupBoxTask_KSJ.Controls.Add(this.dataGridViewTaskMatrix_KSJ);
            this.groupBoxTask_KSJ.Controls.Add(this.textBoxTask_KSJ);
            this.groupBoxTask_KSJ.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KSJ.Name = "groupBoxTask_KSJ";
            this.groupBoxTask_KSJ.Size = new System.Drawing.Size(683, 578);
            this.groupBoxTask_KSJ.TabIndex = 0;
            this.groupBoxTask_KSJ.TabStop = false;
            this.groupBoxTask_KSJ.Text = "Условие";
            // 
            // textBoxTask_KSJ
            // 
            this.textBoxTask_KSJ.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_KSJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KSJ.Location = new System.Drawing.Point(6, 51);
            this.textBoxTask_KSJ.Multiline = true;
            this.textBoxTask_KSJ.Name = "textBoxTask_KSJ";
            this.textBoxTask_KSJ.ReadOnly = true;
            this.textBoxTask_KSJ.Size = new System.Drawing.Size(293, 342);
            this.textBoxTask_KSJ.TabIndex = 0;
            this.textBoxTask_KSJ.Text = "Дана матрица 5 на 5\r\n27 -15 14 2 27\r\n-8 14 -10 33 0\r\n1 7 -11 -11 23\r\n-13 -20 15 -" +
    "16 34\r\n-3  1  -1  5  1\r\nВыполнить сортировку по возрастанию \r\nв первом столбце.\r" +
    "\n\r\n\r\n\r\n\r\n";
            // 
            // groupBoxResult_KSJ
            // 
            this.groupBoxResult_KSJ.Controls.Add(this.dataGridViewResult_KSJ);
            this.groupBoxResult_KSJ.Controls.Add(this.labelResult_KSJ);
            this.groupBoxResult_KSJ.Location = new System.Drawing.Point(701, 27);
            this.groupBoxResult_KSJ.Name = "groupBoxResult_KSJ";
            this.groupBoxResult_KSJ.Size = new System.Drawing.Size(334, 466);
            this.groupBoxResult_KSJ.TabIndex = 1;
            this.groupBoxResult_KSJ.TabStop = false;
            this.groupBoxResult_KSJ.Text = "Вывод данных";
            // 
            // labelResult_KSJ
            // 
            this.labelResult_KSJ.AutoSize = true;
            this.labelResult_KSJ.Location = new System.Drawing.Point(6, 45);
            this.labelResult_KSJ.Name = "labelResult_KSJ";
            this.labelResult_KSJ.Size = new System.Drawing.Size(121, 25);
            this.labelResult_KSJ.TabIndex = 1;
            this.labelResult_KSJ.Text = "Результат:";
            // 
            // dataGridViewResult_KSJ
            // 
            this.dataGridViewResult_KSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KSJ.Location = new System.Drawing.Point(3, 73);
            this.dataGridViewResult_KSJ.Name = "dataGridViewResult_KSJ";
            this.dataGridViewResult_KSJ.RowHeadersWidth = 82;
            this.dataGridViewResult_KSJ.RowTemplate.Height = 33;
            this.dataGridViewResult_KSJ.Size = new System.Drawing.Size(325, 384);
            this.dataGridViewResult_KSJ.TabIndex = 2;
            // 
            // dataGridViewTaskMatrix_KSJ
            // 
            this.dataGridViewTaskMatrix_KSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaskMatrix_KSJ.Location = new System.Drawing.Point(305, 51);
            this.dataGridViewTaskMatrix_KSJ.Name = "dataGridViewTaskMatrix_KSJ";
            this.dataGridViewTaskMatrix_KSJ.RowHeadersWidth = 82;
            this.dataGridViewTaskMatrix_KSJ.RowTemplate.Height = 33;
            this.dataGridViewTaskMatrix_KSJ.Size = new System.Drawing.Size(358, 521);
            this.dataGridViewTaskMatrix_KSJ.TabIndex = 1;
            // 
            // buttonHelp_KSJ
            // 
            this.buttonHelp_KSJ.Location = new System.Drawing.Point(712, 511);
            this.buttonHelp_KSJ.Name = "buttonHelp_KSJ";
            this.buttonHelp_KSJ.Size = new System.Drawing.Size(75, 73);
            this.buttonHelp_KSJ.TabIndex = 2;
            this.buttonHelp_KSJ.Text = "?";
            this.buttonHelp_KSJ.UseVisualStyleBackColor = true;
            this.buttonHelp_KSJ.Click += new System.EventHandler(this.buttonHelp_KSJ_Click);
            // 
            // buttonDone_KSJ
            // 
            this.buttonDone_KSJ.Location = new System.Drawing.Point(812, 526);
            this.buttonDone_KSJ.Name = "buttonDone_KSJ";
            this.buttonDone_KSJ.Size = new System.Drawing.Size(217, 40);
            this.buttonDone_KSJ.TabIndex = 3;
            this.buttonDone_KSJ.Text = "Выполнить";
            this.buttonDone_KSJ.UseVisualStyleBackColor = true;
            this.buttonDone_KSJ.Click += new System.EventHandler(this.buttonDone_KSJ_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 602);
            this.Controls.Add(this.buttonDone_KSJ);
            this.Controls.Add(this.buttonHelp_KSJ);
            this.Controls.Add(this.groupBoxResult_KSJ);
            this.Controls.Add(this.groupBoxTask_KSJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 11 | Коева С.Ю";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KSJ.ResumeLayout(false);
            this.groupBoxTask_KSJ.PerformLayout();
            this.groupBoxResult_KSJ.ResumeLayout(false);
            this.groupBoxResult_KSJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_KSJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KSJ;
        private System.Windows.Forms.TextBox textBoxTask_KSJ;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxResult_KSJ;
        private System.Windows.Forms.Label labelResult_KSJ;
        private System.Windows.Forms.DataGridView dataGridViewTaskMatrix_KSJ;
        private System.Windows.Forms.DataGridView dataGridViewResult_KSJ;
        private System.Windows.Forms.Button buttonHelp_KSJ;
        private System.Windows.Forms.Button buttonDone_KSJ;
    }
}

