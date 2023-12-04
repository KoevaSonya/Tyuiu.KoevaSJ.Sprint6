
namespace Tyuiu.KoevaSJ.Sprint6.Task0.V26
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
            this.buttonDone_KSJ = new System.Windows.Forms.Button();
            this.groupBoxTask_KSJ = new System.Windows.Forms.GroupBox();
            this.groupBoxInputData_KSJ = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_KSJ = new System.Windows.Forms.TextBox();
            this.labelVarX_KSJ = new System.Windows.Forms.Label();
            this.groupBoxResult_KSJ = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KSJ = new System.Windows.Forms.TextBox();
            this.labelResult_KSJ = new System.Windows.Forms.Label();
            this.textBoxTask_KSJ = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_KSJ = new System.Windows.Forms.PictureBox();
            this.buttonHelp_KSJ = new System.Windows.Forms.Button();
            this.groupBoxTask_KSJ.SuspendLayout();
            this.groupBoxInputData_KSJ.SuspendLayout();
            this.groupBoxResult_KSJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KSJ)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_KSJ
            // 
            this.buttonDone_KSJ.Location = new System.Drawing.Point(1000, 699);
            this.buttonDone_KSJ.Name = "buttonDone_KSJ";
            this.buttonDone_KSJ.Size = new System.Drawing.Size(268, 68);
            this.buttonDone_KSJ.TabIndex = 0;
            this.buttonDone_KSJ.Text = "Выполнить";
            this.buttonDone_KSJ.UseVisualStyleBackColor = true;
            this.buttonDone_KSJ.Click += new System.EventHandler(this.buttonDone_KSJ_Click);
            // 
            // groupBoxTask_KSJ
            // 
            this.groupBoxTask_KSJ.Controls.Add(this.pictureBoxFormula_KSJ);
            this.groupBoxTask_KSJ.Controls.Add(this.textBoxTask_KSJ);
            this.groupBoxTask_KSJ.Location = new System.Drawing.Point(50, 76);
            this.groupBoxTask_KSJ.Name = "groupBoxTask_KSJ";
            this.groupBoxTask_KSJ.Size = new System.Drawing.Size(1209, 385);
            this.groupBoxTask_KSJ.TabIndex = 2;
            this.groupBoxTask_KSJ.TabStop = false;
            this.groupBoxTask_KSJ.Text = "Условие";
            // 
            // groupBoxInputData_KSJ
            // 
            this.groupBoxInputData_KSJ.Controls.Add(this.labelVarX_KSJ);
            this.groupBoxInputData_KSJ.Controls.Add(this.textBoxVarX_KSJ);
            this.groupBoxInputData_KSJ.Location = new System.Drawing.Point(50, 499);
            this.groupBoxInputData_KSJ.Name = "groupBoxInputData_KSJ";
            this.groupBoxInputData_KSJ.Size = new System.Drawing.Size(380, 284);
            this.groupBoxInputData_KSJ.TabIndex = 0;
            this.groupBoxInputData_KSJ.TabStop = false;
            this.groupBoxInputData_KSJ.Text = "Ввод данных";
            // 
            // textBoxVarX_KSJ
            // 
            this.textBoxVarX_KSJ.Location = new System.Drawing.Point(21, 93);
            this.textBoxVarX_KSJ.Name = "textBoxVarX_KSJ";
            this.textBoxVarX_KSJ.Size = new System.Drawing.Size(246, 31);
            this.textBoxVarX_KSJ.TabIndex = 0;
            this.textBoxVarX_KSJ.TextChanged += new System.EventHandler(this.textBoxVarX_KSJ_TextChanged);
            this.textBoxVarX_KSJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KSJ_KeyPress);
            // 
            // labelVarX_KSJ
            // 
            this.labelVarX_KSJ.AutoSize = true;
            this.labelVarX_KSJ.Location = new System.Drawing.Point(26, 54);
            this.labelVarX_KSJ.Name = "labelVarX_KSJ";
            this.labelVarX_KSJ.Size = new System.Drawing.Size(163, 25);
            this.labelVarX_KSJ.TabIndex = 1;
            this.labelVarX_KSJ.Text = "Переменная Х:";
            // 
            // groupBoxResult_KSJ
            // 
            this.groupBoxResult_KSJ.Controls.Add(this.labelResult_KSJ);
            this.groupBoxResult_KSJ.Controls.Add(this.textBoxResult_KSJ);
            this.groupBoxResult_KSJ.Location = new System.Drawing.Point(890, 499);
            this.groupBoxResult_KSJ.Name = "groupBoxResult_KSJ";
            this.groupBoxResult_KSJ.Size = new System.Drawing.Size(369, 194);
            this.groupBoxResult_KSJ.TabIndex = 3;
            this.groupBoxResult_KSJ.TabStop = false;
            this.groupBoxResult_KSJ.Text = "Вывод Данных";
            // 
            // textBoxResult_KSJ
            // 
            this.textBoxResult_KSJ.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_KSJ.Location = new System.Drawing.Point(6, 76);
            this.textBoxResult_KSJ.Name = "textBoxResult_KSJ";
            this.textBoxResult_KSJ.ReadOnly = true;
            this.textBoxResult_KSJ.Size = new System.Drawing.Size(357, 31);
            this.textBoxResult_KSJ.TabIndex = 1;
            // 
            // labelResult_KSJ
            // 
            this.labelResult_KSJ.AutoSize = true;
            this.labelResult_KSJ.Location = new System.Drawing.Point(6, 48);
            this.labelResult_KSJ.Name = "labelResult_KSJ";
            this.labelResult_KSJ.Size = new System.Drawing.Size(115, 25);
            this.labelResult_KSJ.TabIndex = 5;
            this.labelResult_KSJ.Text = "Результат";
            // 
            // textBoxTask_KSJ
            // 
            this.textBoxTask_KSJ.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_KSJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KSJ.Location = new System.Drawing.Point(21, 52);
            this.textBoxTask_KSJ.Multiline = true;
            this.textBoxTask_KSJ.Name = "textBoxTask_KSJ";
            this.textBoxTask_KSJ.ReadOnly = true;
            this.textBoxTask_KSJ.Size = new System.Drawing.Size(359, 34);
            this.textBoxTask_KSJ.TabIndex = 0;
            this.textBoxTask_KSJ.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_KSJ
            // 
            this.pictureBoxFormula_KSJ.Image = global::Tyuiu.KoevaSJ.Sprint6.Task0.V26.Properties.Resources.Таск0фото;
            this.pictureBoxFormula_KSJ.Location = new System.Drawing.Point(840, 30);
            this.pictureBoxFormula_KSJ.Name = "pictureBoxFormula_KSJ";
            this.pictureBoxFormula_KSJ.Size = new System.Drawing.Size(353, 155);
            this.pictureBoxFormula_KSJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormula_KSJ.TabIndex = 4;
            this.pictureBoxFormula_KSJ.TabStop = false;
            // 
            // buttonHelp_KSJ
            // 
            this.buttonHelp_KSJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KSJ.Location = new System.Drawing.Point(896, 712);
            this.buttonHelp_KSJ.Name = "buttonHelp_KSJ";
            this.buttonHelp_KSJ.Size = new System.Drawing.Size(98, 55);
            this.buttonHelp_KSJ.TabIndex = 4;
            this.buttonHelp_KSJ.Text = "?";
            this.buttonHelp_KSJ.UseVisualStyleBackColor = true;
            this.buttonHelp_KSJ.Click += new System.EventHandler(this.buttonHelp_KSJ_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 796);
            this.Controls.Add(this.buttonHelp_KSJ);
            this.Controls.Add(this.groupBoxResult_KSJ);
            this.Controls.Add(this.groupBoxInputData_KSJ);
            this.Controls.Add(this.groupBoxTask_KSJ);
            this.Controls.Add(this.buttonDone_KSJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 26 | Коева С.Ю";
            this.groupBoxTask_KSJ.ResumeLayout(false);
            this.groupBoxTask_KSJ.PerformLayout();
            this.groupBoxInputData_KSJ.ResumeLayout(false);
            this.groupBoxInputData_KSJ.PerformLayout();
            this.groupBoxResult_KSJ.ResumeLayout(false);
            this.groupBoxResult_KSJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KSJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_KSJ;
        private System.Windows.Forms.GroupBox groupBoxTask_KSJ;
        private System.Windows.Forms.GroupBox groupBoxInputData_KSJ;
        private System.Windows.Forms.TextBox textBoxVarX_KSJ;
        private System.Windows.Forms.Label labelVarX_KSJ;
        private System.Windows.Forms.GroupBox groupBoxResult_KSJ;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KSJ;
        private System.Windows.Forms.TextBox textBoxTask_KSJ;
        private System.Windows.Forms.Label labelResult_KSJ;
        private System.Windows.Forms.TextBox textBoxResult_KSJ;
        private System.Windows.Forms.Button buttonHelp_KSJ;
    }
}

