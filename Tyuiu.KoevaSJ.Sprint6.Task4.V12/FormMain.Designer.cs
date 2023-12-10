
namespace Tyuiu.KoevaSJ.Sprint6.Task4.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_KSJ = new System.Windows.Forms.GroupBox();
            this.groupBoxInputData_KSJ = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KSJ = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.buttonHelp_KSJ = new System.Windows.Forms.Button();
            this.buttonSave_KSJ = new System.Windows.Forms.Button();
            this.buttonDone_KSJ = new System.Windows.Forms.Button();
            this.labelStopStep_KSJ = new System.Windows.Forms.Label();
            this.labelStartStep_KSJ = new System.Windows.Forms.Label();
            this.textBoxStopStep_KSJ = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KSJ = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KSJ = new System.Windows.Forms.GroupBox();
            this.chartFunction_KSJ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBoxResult_KSJ = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KSJ.SuspendLayout();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxResult_KSJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KSJ)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KSJ
            // 
            this.groupBoxTask_KSJ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxTask_KSJ.Controls.Add(this.groupBoxInputData_KSJ);
            this.groupBoxTask_KSJ.Controls.Add(this.textBoxTask_KSJ);
            this.groupBoxTask_KSJ.Location = new System.Drawing.Point(0, 12);
            this.groupBoxTask_KSJ.Name = "groupBoxTask_KSJ";
            this.groupBoxTask_KSJ.Size = new System.Drawing.Size(837, 136);
            this.groupBoxTask_KSJ.TabIndex = 0;
            this.groupBoxTask_KSJ.TabStop = false;
            this.groupBoxTask_KSJ.Text = "Условие";
            // 
            // groupBoxInputData_KSJ
            // 
            this.groupBoxInputData_KSJ.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxInputData_KSJ.Location = new System.Drawing.Point(843, 0);
            this.groupBoxInputData_KSJ.Name = "groupBoxInputData_KSJ";
            this.groupBoxInputData_KSJ.Size = new System.Drawing.Size(706, 124);
            this.groupBoxInputData_KSJ.TabIndex = 1;
            this.groupBoxInputData_KSJ.TabStop = false;
            this.groupBoxInputData_KSJ.Text = "groupBox1";
            // 
            // textBoxTask_KSJ
            // 
            this.textBoxTask_KSJ.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_KSJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KSJ.Location = new System.Drawing.Point(12, 30);
            this.textBoxTask_KSJ.Multiline = true;
            this.textBoxTask_KSJ.Name = "textBoxTask_KSJ";
            this.textBoxTask_KSJ.ReadOnly = true;
            this.textBoxTask_KSJ.Size = new System.Drawing.Size(792, 94);
            this.textBoxTask_KSJ.TabIndex = 0;
            this.textBoxTask_KSJ.Text = "Протабулировать функцию F(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывести" +
    " в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V12.txt " +
    "по нажатию кнопки.\r\n";
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxInputData.Controls.Add(this.buttonHelp_KSJ);
            this.groupBoxInputData.Controls.Add(this.buttonSave_KSJ);
            this.groupBoxInputData.Controls.Add(this.buttonDone_KSJ);
            this.groupBoxInputData.Controls.Add(this.labelStopStep_KSJ);
            this.groupBoxInputData.Controls.Add(this.labelStartStep_KSJ);
            this.groupBoxInputData.Controls.Add(this.textBoxStopStep_KSJ);
            this.groupBoxInputData.Controls.Add(this.textBoxStartStep_KSJ);
            this.groupBoxInputData.Location = new System.Drawing.Point(843, 12);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(875, 136);
            this.groupBoxInputData.TabIndex = 1;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных";
            // 
            // buttonHelp_KSJ
            // 
            this.buttonHelp_KSJ.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_KSJ.Location = new System.Drawing.Point(712, 21);
            this.buttonHelp_KSJ.Name = "buttonHelp_KSJ";
            this.buttonHelp_KSJ.Size = new System.Drawing.Size(148, 97);
            this.buttonHelp_KSJ.TabIndex = 7;
            this.buttonHelp_KSJ.Text = "Справка";
            this.buttonHelp_KSJ.UseVisualStyleBackColor = false;
            this.buttonHelp_KSJ.Click += new System.EventHandler(this.buttonHelp_KSJ_Click);
            // 
            // buttonSave_KSJ
            // 
            this.buttonSave_KSJ.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSave_KSJ.Location = new System.Drawing.Point(551, 21);
            this.buttonSave_KSJ.Name = "buttonSave_KSJ";
            this.buttonSave_KSJ.Size = new System.Drawing.Size(149, 97);
            this.buttonSave_KSJ.TabIndex = 6;
            this.buttonSave_KSJ.Text = "Сохранить";
            this.buttonSave_KSJ.UseVisualStyleBackColor = false;
            this.buttonSave_KSJ.Click += new System.EventHandler(this.buttonSave_KSJ_Click);
            // 
            // buttonDone_KSJ
            // 
            this.buttonDone_KSJ.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KSJ.Location = new System.Drawing.Point(394, 21);
            this.buttonDone_KSJ.Name = "buttonDone_KSJ";
            this.buttonDone_KSJ.Size = new System.Drawing.Size(151, 97);
            this.buttonDone_KSJ.TabIndex = 2;
            this.buttonDone_KSJ.Text = "Выполнить ";
            this.buttonDone_KSJ.UseVisualStyleBackColor = false;
            this.buttonDone_KSJ.Click += new System.EventHandler(this.buttonDone_KSJ_Click);
            // 
            // labelStopStep_KSJ
            // 
            this.labelStopStep_KSJ.AutoSize = true;
            this.labelStopStep_KSJ.Location = new System.Drawing.Point(220, 47);
            this.labelStopStep_KSJ.Name = "labelStopStep_KSJ";
            this.labelStopStep_KSJ.Size = new System.Drawing.Size(135, 25);
            this.labelStopStep_KSJ.TabIndex = 5;
            this.labelStopStep_KSJ.Text = "Конец шага:";
            // 
            // labelStartStep_KSJ
            // 
            this.labelStartStep_KSJ.AutoSize = true;
            this.labelStartStep_KSJ.Location = new System.Drawing.Point(22, 47);
            this.labelStartStep_KSJ.Name = "labelStartStep_KSJ";
            this.labelStartStep_KSJ.Size = new System.Drawing.Size(132, 25);
            this.labelStartStep_KSJ.TabIndex = 4;
            this.labelStartStep_KSJ.Text = "Старт шага:";
            // 
            // textBoxStopStep_KSJ
            // 
            this.textBoxStopStep_KSJ.Location = new System.Drawing.Point(216, 75);
            this.textBoxStopStep_KSJ.Name = "textBoxStopStep_KSJ";
            this.textBoxStopStep_KSJ.Size = new System.Drawing.Size(150, 31);
            this.textBoxStopStep_KSJ.TabIndex = 3;
            this.textBoxStopStep_KSJ.Text = "5";
            // 
            // textBoxStartStep_KSJ
            // 
            this.textBoxStartStep_KSJ.Location = new System.Drawing.Point(16, 75);
            this.textBoxStartStep_KSJ.Name = "textBoxStartStep_KSJ";
            this.textBoxStartStep_KSJ.Size = new System.Drawing.Size(179, 31);
            this.textBoxStartStep_KSJ.TabIndex = 2;
            this.textBoxStartStep_KSJ.Text = "-5";
            // 
            // groupBoxResult_KSJ
            // 
            this.groupBoxResult_KSJ.Controls.Add(this.textBoxResult_KSJ);
            this.groupBoxResult_KSJ.Location = new System.Drawing.Point(12, 154);
            this.groupBoxResult_KSJ.Name = "groupBoxResult_KSJ";
            this.groupBoxResult_KSJ.Size = new System.Drawing.Size(502, 845);
            this.groupBoxResult_KSJ.TabIndex = 2;
            this.groupBoxResult_KSJ.TabStop = false;
            this.groupBoxResult_KSJ.Text = "Вывод:";
            // 
            // chartFunction_KSJ
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_KSJ.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_KSJ.Legends.Add(legend2);
            this.chartFunction_KSJ.Location = new System.Drawing.Point(520, 165);
            this.chartFunction_KSJ.Name = "chartFunction_KSJ";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_KSJ.Series.Add(series2);
            this.chartFunction_KSJ.Size = new System.Drawing.Size(1198, 834);
            this.chartFunction_KSJ.TabIndex = 6;
            this.chartFunction_KSJ.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "График функции F(x)";
            this.chartFunction_KSJ.Titles.Add(title2);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 926);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1724, 3);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // textBoxResult_KSJ
            // 
            this.textBoxResult_KSJ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxResult_KSJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_KSJ.Location = new System.Drawing.Point(6, 41);
            this.textBoxResult_KSJ.Multiline = true;
            this.textBoxResult_KSJ.Name = "textBoxResult_KSJ";
            this.textBoxResult_KSJ.ReadOnly = true;
            this.textBoxResult_KSJ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KSJ.Size = new System.Drawing.Size(465, 798);
            this.textBoxResult_KSJ.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 929);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.chartFunction_KSJ);
            this.Controls.Add(this.groupBoxResult_KSJ);
            this.Controls.Add(this.groupBoxInputData);
            this.Controls.Add(this.groupBoxTask_KSJ);
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 12 | Коева С.Ю";
            this.groupBoxTask_KSJ.ResumeLayout(false);
            this.groupBoxTask_KSJ.PerformLayout();
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxResult_KSJ.ResumeLayout(false);
            this.groupBoxResult_KSJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KSJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KSJ;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxTask_KSJ;
        private System.Windows.Forms.GroupBox groupBoxInputData_KSJ;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.TextBox textBoxStopStep_KSJ;
        private System.Windows.Forms.TextBox textBoxStartStep_KSJ;
        private System.Windows.Forms.Label labelStartStep_KSJ;
        private System.Windows.Forms.Label labelStopStep_KSJ;
        private System.Windows.Forms.Button buttonSave_KSJ;
        private System.Windows.Forms.Button buttonDone_KSJ;
        private System.Windows.Forms.Button buttonHelp_KSJ;
        private System.Windows.Forms.GroupBox groupBoxResult_KSJ;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KSJ;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBoxResult_KSJ;
    }
}

