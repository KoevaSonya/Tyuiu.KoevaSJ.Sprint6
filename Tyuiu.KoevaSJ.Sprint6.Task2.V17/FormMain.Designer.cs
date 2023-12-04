
namespace Tyuiu.KoevaSJ.Sprint6.Task2.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KSJ = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KSJ = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInputData_KSJ = new System.Windows.Forms.GroupBox();
            this.labelStopStep_KSJ = new System.Windows.Forms.Label();
            this.textBoxStopStep_KSJ = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KSJ = new System.Windows.Forms.TextBox();
            this.labelStartStep_KSJ = new System.Windows.Forms.Label();
            this.buttonHelp_KSJ = new System.Windows.Forms.Button();
            this.buttonDone_KSJ = new System.Windows.Forms.Button();
            this.groupBoxResult_KSJ = new System.Windows.Forms.GroupBox();
            this.chartFunction_KSJ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_KSJ = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_KSJ = new System.Windows.Forms.Label();
            this.groupBoxTask_KSJ.SuspendLayout();
            this.groupBoxInputData_KSJ.SuspendLayout();
            this.groupBoxResult_KSJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KSJ)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KSJ
            // 
            this.groupBoxTask_KSJ.Controls.Add(this.textBoxTask_KSJ);
            this.groupBoxTask_KSJ.Location = new System.Drawing.Point(27, 22);
            this.groupBoxTask_KSJ.Name = "groupBoxTask_KSJ";
            this.groupBoxTask_KSJ.Size = new System.Drawing.Size(672, 398);
            this.groupBoxTask_KSJ.TabIndex = 0;
            this.groupBoxTask_KSJ.TabStop = false;
            this.groupBoxTask_KSJ.Text = "Условие";
            // 
            // textBoxTask_KSJ
            // 
            this.textBoxTask_KSJ.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_KSJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KSJ.Location = new System.Drawing.Point(6, 47);
            this.textBoxTask_KSJ.Multiline = true;
            this.textBoxTask_KSJ.Name = "textBoxTask_KSJ";
            this.textBoxTask_KSJ.ReadOnly = true;
            this.textBoxTask_KSJ.Size = new System.Drawing.Size(752, 60);
            this.textBoxTask_KSJ.TabIndex = 0;
            this.textBoxTask_KSJ.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в DataGrin" +
    "dView и построить график функции.\r\n";
            this.textBoxTask_KSJ.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxInputData_KSJ
            // 
            this.groupBoxInputData_KSJ.Controls.Add(this.labelStopStep_KSJ);
            this.groupBoxInputData_KSJ.Controls.Add(this.textBoxStopStep_KSJ);
            this.groupBoxInputData_KSJ.Controls.Add(this.textBoxStartStep_KSJ);
            this.groupBoxInputData_KSJ.Controls.Add(this.labelStartStep_KSJ);
            this.groupBoxInputData_KSJ.Location = new System.Drawing.Point(27, 441);
            this.groupBoxInputData_KSJ.Name = "groupBoxInputData_KSJ";
            this.groupBoxInputData_KSJ.Size = new System.Drawing.Size(383, 134);
            this.groupBoxInputData_KSJ.TabIndex = 1;
            this.groupBoxInputData_KSJ.TabStop = false;
            this.groupBoxInputData_KSJ.Text = "Ввод данных";
            // 
            // labelStopStep_KSJ
            // 
            this.labelStopStep_KSJ.AutoSize = true;
            this.labelStopStep_KSJ.Location = new System.Drawing.Point(240, 36);
            this.labelStopStep_KSJ.Name = "labelStopStep_KSJ";
            this.labelStopStep_KSJ.Size = new System.Drawing.Size(135, 25);
            this.labelStopStep_KSJ.TabIndex = 3;
            this.labelStopStep_KSJ.Text = "Конец шага:";
            // 
            // textBoxStopStep_KSJ
            // 
            this.textBoxStopStep_KSJ.Location = new System.Drawing.Point(245, 76);
            this.textBoxStopStep_KSJ.Name = "textBoxStopStep_KSJ";
            this.textBoxStopStep_KSJ.Size = new System.Drawing.Size(104, 31);
            this.textBoxStopStep_KSJ.TabIndex = 2;
            this.textBoxStopStep_KSJ.Text = "5";
            // 
            // textBoxStartStep_KSJ
            // 
            this.textBoxStartStep_KSJ.Location = new System.Drawing.Point(8, 76);
            this.textBoxStartStep_KSJ.Name = "textBoxStartStep_KSJ";
            this.textBoxStartStep_KSJ.Size = new System.Drawing.Size(231, 31);
            this.textBoxStartStep_KSJ.TabIndex = 1;
            this.textBoxStartStep_KSJ.Text = "-5";
            // 
            // labelStartStep_KSJ
            // 
            this.labelStartStep_KSJ.AutoSize = true;
            this.labelStartStep_KSJ.Location = new System.Drawing.Point(6, 36);
            this.labelStartStep_KSJ.Name = "labelStartStep_KSJ";
            this.labelStartStep_KSJ.Size = new System.Drawing.Size(138, 25);
            this.labelStartStep_KSJ.TabIndex = 0;
            this.labelStartStep_KSJ.Text = "Старт шага: ";
            this.labelStartStep_KSJ.Click += new System.EventHandler(this.labelStartStep_Click);
            // 
            // buttonHelp_KSJ
            // 
            this.buttonHelp_KSJ.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_KSJ.Location = new System.Drawing.Point(428, 453);
            this.buttonHelp_KSJ.Name = "buttonHelp_KSJ";
            this.buttonHelp_KSJ.Size = new System.Drawing.Size(117, 122);
            this.buttonHelp_KSJ.TabIndex = 4;
            this.buttonHelp_KSJ.Text = "Справка";
            this.buttonHelp_KSJ.UseVisualStyleBackColor = false;
            this.buttonHelp_KSJ.Click += new System.EventHandler(this.buttonHelp_KSJ_Click);
            // 
            // buttonDone_KSJ
            // 
            this.buttonDone_KSJ.BackColor = System.Drawing.Color.Aqua;
            this.buttonDone_KSJ.Location = new System.Drawing.Point(551, 453);
            this.buttonDone_KSJ.Name = "buttonDone_KSJ";
            this.buttonDone_KSJ.Size = new System.Drawing.Size(136, 122);
            this.buttonDone_KSJ.TabIndex = 5;
            this.buttonDone_KSJ.Text = "Выполнить";
            this.buttonDone_KSJ.UseVisualStyleBackColor = false;
            this.buttonDone_KSJ.Click += new System.EventHandler(this.buttonDone_KSJ_Click);
            this.buttonDone_KSJ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_KSJ_MouseDown);
            this.buttonDone_KSJ.MouseEnter += new System.EventHandler(this.buttonDone_KSJ_MouseEnter);
            this.buttonDone_KSJ.MouseLeave += new System.EventHandler(this.buttonDone_KSJ_MouseLeave);
            // 
            // groupBoxResult_KSJ
            // 
            this.groupBoxResult_KSJ.Controls.Add(this.chartFunction_KSJ);
            this.groupBoxResult_KSJ.Controls.Add(this.dataGridViewFunction_KSJ);
            this.groupBoxResult_KSJ.Controls.Add(this.labelResult_KSJ);
            this.groupBoxResult_KSJ.Location = new System.Drawing.Point(705, 38);
            this.groupBoxResult_KSJ.Name = "groupBoxResult_KSJ";
            this.groupBoxResult_KSJ.Size = new System.Drawing.Size(1076, 537);
            this.groupBoxResult_KSJ.TabIndex = 6;
            this.groupBoxResult_KSJ.TabStop = false;
            this.groupBoxResult_KSJ.Text = "Вывод данных";
            // 
            // chartFunction_KSJ
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KSJ.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_KSJ.Legends.Add(legend1);
            this.chartFunction_KSJ.Location = new System.Drawing.Point(265, 75);
            this.chartFunction_KSJ.Name = "chartFunction_KSJ";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KSJ.Series.Add(series1);
            this.chartFunction_KSJ.Size = new System.Drawing.Size(805, 456);
            this.chartFunction_KSJ.TabIndex = 6;
            this.chartFunction_KSJ.Text = "chart1";
            // 
            // dataGridViewFunction_KSJ
            // 
            this.dataGridViewFunction_KSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_KSJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFunction_KSJ.Location = new System.Drawing.Point(0, 75);
            this.dataGridViewFunction_KSJ.Name = "dataGridViewFunction_KSJ";
            this.dataGridViewFunction_KSJ.RowHeadersVisible = false;
            this.dataGridViewFunction_KSJ.RowHeadersWidth = 82;
            this.dataGridViewFunction_KSJ.RowTemplate.Height = 33;
            this.dataGridViewFunction_KSJ.Size = new System.Drawing.Size(259, 456);
            this.dataGridViewFunction_KSJ.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(x)";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // labelResult_KSJ
            // 
            this.labelResult_KSJ.AutoSize = true;
            this.labelResult_KSJ.Location = new System.Drawing.Point(15, 31);
            this.labelResult_KSJ.Name = "labelResult_KSJ";
            this.labelResult_KSJ.Size = new System.Drawing.Size(121, 25);
            this.labelResult_KSJ.TabIndex = 0;
            this.labelResult_KSJ.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 587);
            this.Controls.Add(this.groupBoxResult_KSJ);
            this.Controls.Add(this.buttonDone_KSJ);
            this.Controls.Add(this.buttonHelp_KSJ);
            this.Controls.Add(this.groupBoxInputData_KSJ);
            this.Controls.Add(this.groupBoxTask_KSJ);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 17 | Коева С.Ю";
            this.groupBoxTask_KSJ.ResumeLayout(false);
            this.groupBoxTask_KSJ.PerformLayout();
            this.groupBoxInputData_KSJ.ResumeLayout(false);
            this.groupBoxInputData_KSJ.PerformLayout();
            this.groupBoxResult_KSJ.ResumeLayout(false);
            this.groupBoxResult_KSJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KSJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KSJ;
        private System.Windows.Forms.TextBox textBoxTask_KSJ;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxInputData_KSJ;
        private System.Windows.Forms.TextBox textBoxStartStep_KSJ;
        private System.Windows.Forms.Label labelStartStep_KSJ;
        private System.Windows.Forms.Label labelStopStep_KSJ;
        private System.Windows.Forms.TextBox textBoxStopStep_KSJ;
        private System.Windows.Forms.Button buttonHelp_KSJ;
        private System.Windows.Forms.Button buttonDone_KSJ;
        private System.Windows.Forms.GroupBox groupBoxResult_KSJ;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KSJ;
        private System.Windows.Forms.DataGridView dataGridViewFunction_KSJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label labelResult_KSJ;
    }
}

