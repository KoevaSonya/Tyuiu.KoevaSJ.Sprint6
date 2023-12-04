
namespace Tyuiu.KoevaSJ.Sprint6.Task1.V16
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
            this.textBoxTask_KSJ = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KSJ = new System.Windows.Forms.GroupBox();
            this.labelResult_KSJ = new System.Windows.Forms.Label();
            this.textBoxResult_KSJ = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_KSJ = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_KSJ = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_KSJ = new System.Windows.Forms.TextBox();
            this.labelStartStep_KSJ = new System.Windows.Forms.Label();
            this.labelStopStep_KSJ = new System.Windows.Forms.Label();
            this.buttonHelp_KSJ = new System.Windows.Forms.Button();
            this.buttonDone_KSJ = new System.Windows.Forms.Button();
            this.groupBoxTask_KSJ.SuspendLayout();
            this.groupBoxResult_KSJ.SuspendLayout();
            this.groupBoxInputData_KSJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KSJ
            // 
            this.groupBoxTask_KSJ.Controls.Add(this.textBoxTask_KSJ);
            this.groupBoxTask_KSJ.Location = new System.Drawing.Point(30, 25);
            this.groupBoxTask_KSJ.Name = "groupBoxTask_KSJ";
            this.groupBoxTask_KSJ.Size = new System.Drawing.Size(652, 309);
            this.groupBoxTask_KSJ.TabIndex = 0;
            this.groupBoxTask_KSJ.TabStop = false;
            this.groupBoxTask_KSJ.Text = "Условие";
            // 
            // textBoxTask_KSJ
            // 
            this.textBoxTask_KSJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KSJ.Location = new System.Drawing.Point(22, 30);
            this.textBoxTask_KSJ.Multiline = true;
            this.textBoxTask_KSJ.Name = "textBoxTask_KSJ";
            this.textBoxTask_KSJ.ReadOnly = true;
            this.textBoxTask_KSJ.Size = new System.Drawing.Size(590, 83);
            this.textBoxTask_KSJ.TabIndex = 0;
            this.textBoxTask_KSJ.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в виде таб" +
    "лицы.\r\n";
            // 
            // groupBoxResult_KSJ
            // 
            this.groupBoxResult_KSJ.Controls.Add(this.textBoxResult_KSJ);
            this.groupBoxResult_KSJ.Controls.Add(this.labelResult_KSJ);
            this.groupBoxResult_KSJ.Location = new System.Drawing.Point(699, 34);
            this.groupBoxResult_KSJ.Name = "groupBoxResult_KSJ";
            this.groupBoxResult_KSJ.Size = new System.Drawing.Size(419, 458);
            this.groupBoxResult_KSJ.TabIndex = 1;
            this.groupBoxResult_KSJ.TabStop = false;
            this.groupBoxResult_KSJ.Text = "Вывод данных";
            this.groupBoxResult_KSJ.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelResult_KSJ
            // 
            this.labelResult_KSJ.AutoSize = true;
            this.labelResult_KSJ.Location = new System.Drawing.Point(6, 36);
            this.labelResult_KSJ.Name = "labelResult_KSJ";
            this.labelResult_KSJ.Size = new System.Drawing.Size(121, 25);
            this.labelResult_KSJ.TabIndex = 0;
            this.labelResult_KSJ.Text = "Результат:";
            // 
            // textBoxResult_KSJ
            // 
            this.textBoxResult_KSJ.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_KSJ.Font = new System.Drawing.Font("Consolas", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_KSJ.Location = new System.Drawing.Point(11, 69);
            this.textBoxResult_KSJ.Multiline = true;
            this.textBoxResult_KSJ.Name = "textBoxResult_KSJ";
            this.textBoxResult_KSJ.ReadOnly = true;
            this.textBoxResult_KSJ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KSJ.Size = new System.Drawing.Size(402, 423);
            this.textBoxResult_KSJ.TabIndex = 3;
            // 
            // groupBoxInputData_KSJ
            // 
            this.groupBoxInputData_KSJ.Controls.Add(this.labelStopStep_KSJ);
            this.groupBoxInputData_KSJ.Controls.Add(this.labelStartStep_KSJ);
            this.groupBoxInputData_KSJ.Controls.Add(this.textBoxStopStep_KSJ);
            this.groupBoxInputData_KSJ.Controls.Add(this.textBoxStartStep_KSJ);
            this.groupBoxInputData_KSJ.Location = new System.Drawing.Point(30, 353);
            this.groupBoxInputData_KSJ.Name = "groupBoxInputData_KSJ";
            this.groupBoxInputData_KSJ.Size = new System.Drawing.Size(363, 173);
            this.groupBoxInputData_KSJ.TabIndex = 2;
            this.groupBoxInputData_KSJ.TabStop = false;
            this.groupBoxInputData_KSJ.Text = "Ввод данных";
            this.groupBoxInputData_KSJ.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // textBoxStartStep_KSJ
            // 
            this.textBoxStartStep_KSJ.Location = new System.Drawing.Point(6, 108);
            this.textBoxStartStep_KSJ.Name = "textBoxStartStep_KSJ";
            this.textBoxStartStep_KSJ.Size = new System.Drawing.Size(147, 31);
            this.textBoxStartStep_KSJ.TabIndex = 0;
            this.textBoxStartStep_KSJ.Text = "-5";
            this.textBoxStartStep_KSJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarStartStep_KDR_KeyPress);
            // 
            // textBoxStopStep_KSJ
            // 
            this.textBoxStopStep_KSJ.Location = new System.Drawing.Point(170, 108);
            this.textBoxStopStep_KSJ.Name = "textBoxStopStep_KSJ";
            this.textBoxStopStep_KSJ.Size = new System.Drawing.Size(161, 31);
            this.textBoxStopStep_KSJ.TabIndex = 1;
            this.textBoxStopStep_KSJ.Text = "5";
            // 
            // labelStartStep_KSJ
            // 
            this.labelStartStep_KSJ.AutoSize = true;
            this.labelStartStep_KSJ.Location = new System.Drawing.Point(6, 68);
            this.labelStartStep_KSJ.Name = "labelStartStep_KSJ";
            this.labelStartStep_KSJ.Size = new System.Drawing.Size(132, 25);
            this.labelStartStep_KSJ.TabIndex = 2;
            this.labelStartStep_KSJ.Text = "Старт шага:";
            // 
            // labelStopStep_KSJ
            // 
            this.labelStopStep_KSJ.AutoSize = true;
            this.labelStopStep_KSJ.Location = new System.Drawing.Point(180, 68);
            this.labelStopStep_KSJ.Name = "labelStopStep_KSJ";
            this.labelStopStep_KSJ.Size = new System.Drawing.Size(135, 25);
            this.labelStopStep_KSJ.TabIndex = 3;
            this.labelStopStep_KSJ.Text = "Конец шага:";
            // 
            // buttonHelp_KSJ
            // 
            this.buttonHelp_KSJ.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_KSJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KSJ.Location = new System.Drawing.Point(399, 389);
            this.buttonHelp_KSJ.Name = "buttonHelp_KSJ";
            this.buttonHelp_KSJ.Size = new System.Drawing.Size(121, 103);
            this.buttonHelp_KSJ.TabIndex = 4;
            this.buttonHelp_KSJ.Text = "Справка";
            this.buttonHelp_KSJ.UseVisualStyleBackColor = false;
            this.buttonHelp_KSJ.Click += new System.EventHandler(this.buttonHelp_KSJ_Click);
            // 
            // buttonDone_KSJ
            // 
            this.buttonDone_KSJ.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KSJ.Location = new System.Drawing.Point(526, 389);
            this.buttonDone_KSJ.Name = "buttonDone_KSJ";
            this.buttonDone_KSJ.Size = new System.Drawing.Size(167, 103);
            this.buttonDone_KSJ.TabIndex = 4;
            this.buttonDone_KSJ.Text = "Выполнить";
            this.buttonDone_KSJ.UseVisualStyleBackColor = false;
            this.buttonDone_KSJ.Click += new System.EventHandler(this.buttonDone_KSJ_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 538);
            this.Controls.Add(this.buttonDone_KSJ);
            this.Controls.Add(this.buttonHelp_KSJ);
            this.Controls.Add(this.groupBoxInputData_KSJ);
            this.Controls.Add(this.groupBoxResult_KSJ);
            this.Controls.Add(this.groupBoxTask_KSJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 16 | Коева С.Ю";
            this.groupBoxTask_KSJ.ResumeLayout(false);
            this.groupBoxTask_KSJ.PerformLayout();
            this.groupBoxResult_KSJ.ResumeLayout(false);
            this.groupBoxResult_KSJ.PerformLayout();
            this.groupBoxInputData_KSJ.ResumeLayout(false);
            this.groupBoxInputData_KSJ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KSJ;
        private System.Windows.Forms.TextBox textBoxTask_KSJ;
        private System.Windows.Forms.GroupBox groupBoxResult_KSJ;
        private System.Windows.Forms.TextBox textBoxResult_KSJ;
        private System.Windows.Forms.Label labelResult_KSJ;
        private System.Windows.Forms.GroupBox groupBoxInputData_KSJ;
        private System.Windows.Forms.Label labelStopStep_KSJ;
        private System.Windows.Forms.Label labelStartStep_KSJ;
        private System.Windows.Forms.TextBox textBoxStopStep_KSJ;
        private System.Windows.Forms.TextBox textBoxStartStep_KSJ;
        private System.Windows.Forms.Button buttonHelp_KSJ;
        private System.Windows.Forms.Button buttonDone_KSJ;
    }
}

