
namespace Tyuiu.KoevaSJ.Sprint6.Task5.V10
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_KSJ = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KSJ = new System.Windows.Forms.TextBox();
            this.groupBoxResult_ = new System.Windows.Forms.GroupBox();
            this.chartFunction_KSJ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_KSJ = new System.Windows.Forms.DataGridView();
            this.buttonDone_KSJ = new System.Windows.Forms.Button();
            this.buttonOpen_KSJ = new System.Windows.Forms.Button();
            this.buttonHelp_KSJ = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxTask_KSJ.SuspendLayout();
            this.groupBoxResult_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KSJ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_KSJ);
            this.panel1.Controls.Add(this.buttonOpen_KSJ);
            this.panel1.Controls.Add(this.buttonDone_KSJ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1643, 100);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxResult_);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(241, 788);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartFunction_KSJ);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(241, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1402, 788);
            this.panel2.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(241, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 788);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBoxTask_KSJ
            // 
            this.groupBoxTask_KSJ.Controls.Add(this.textBoxTask_KSJ);
            this.groupBoxTask_KSJ.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_KSJ.Name = "groupBoxTask_KSJ";
            this.groupBoxTask_KSJ.Size = new System.Drawing.Size(1195, 94);
            this.groupBoxTask_KSJ.TabIndex = 3;
            this.groupBoxTask_KSJ.TabStop = false;
            this.groupBoxTask_KSJ.Text = "Условие";
            // 
            // textBoxTask_KSJ
            // 
            this.textBoxTask_KSJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTask_KSJ.Location = new System.Drawing.Point(12, 30);
            this.textBoxTask_KSJ.Multiline = true;
            this.textBoxTask_KSJ.Name = "textBoxTask_KSJ";
            this.textBoxTask_KSJ.ReadOnly = true;
            this.textBoxTask_KSJ.Size = new System.Drawing.Size(1160, 58);
            this.textBoxTask_KSJ.TabIndex = 0;
            this.textBoxTask_KSJ.Text = "Прочитать данные из файла InPutFileTask5V10.txt. Вывести в dataGridView\r\nвсе числ" +
    "а, не равные 0. Построить диаграмму по этим значениям.\r\n\r\n";
            // 
            // groupBoxResult_
            // 
            this.groupBoxResult_.Controls.Add(this.dataGridViewResult_KSJ);
            this.groupBoxResult_.Location = new System.Drawing.Point(3, 3);
            this.groupBoxResult_.Name = "groupBoxResult_";
            this.groupBoxResult_.Size = new System.Drawing.Size(232, 773);
            this.groupBoxResult_.TabIndex = 0;
            this.groupBoxResult_.TabStop = false;
            this.groupBoxResult_.Text = "Вывод данных:";
            // 
            // chartFunction_KSJ
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KSJ.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_KSJ.Legends.Add(legend1);
            this.chartFunction_KSJ.Location = new System.Drawing.Point(16, 6);
            this.chartFunction_KSJ.Name = "chartFunction_KSJ";
            this.chartFunction_KSJ.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KSJ.Series.Add(series1);
            this.chartFunction_KSJ.Size = new System.Drawing.Size(1310, 770);
            this.chartFunction_KSJ.TabIndex = 1;
            this.chartFunction_KSJ.Text = "chart1";
            // 
            // dataGridViewResult_KSJ
            // 
            this.dataGridViewResult_KSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KSJ.Location = new System.Drawing.Point(3, 27);
            this.dataGridViewResult_KSJ.Name = "dataGridViewResult_KSJ";
            this.dataGridViewResult_KSJ.RowHeadersWidth = 82;
            this.dataGridViewResult_KSJ.RowTemplate.Height = 33;
            this.dataGridViewResult_KSJ.Size = new System.Drawing.Size(240, 740);
            this.dataGridViewResult_KSJ.TabIndex = 0;
            // 
            // buttonDone_KSJ
            // 
            this.buttonDone_KSJ.Location = new System.Drawing.Point(1201, 12);
            this.buttonDone_KSJ.Name = "buttonDone_KSJ";
            this.buttonDone_KSJ.Size = new System.Drawing.Size(134, 76);
            this.buttonDone_KSJ.TabIndex = 2;
            this.buttonDone_KSJ.Text = "Выполнить";
            this.buttonDone_KSJ.UseVisualStyleBackColor = true;
            this.buttonDone_KSJ.Click += new System.EventHandler(this.buttonDone_KSJ_Click);
            // 
            // buttonOpen_KSJ
            // 
            this.buttonOpen_KSJ.Location = new System.Drawing.Point(1365, 12);
            this.buttonOpen_KSJ.Name = "buttonOpen_KSJ";
            this.buttonOpen_KSJ.Size = new System.Drawing.Size(113, 76);
            this.buttonOpen_KSJ.TabIndex = 3;
            this.buttonOpen_KSJ.Text = "Открыть\r\nфайл\r\n";
            this.buttonOpen_KSJ.UseVisualStyleBackColor = true;
            this.buttonOpen_KSJ.Click += new System.EventHandler(this.buttonOpen_KSJ_Click);
            // 
            // buttonHelp_KSJ
            // 
            this.buttonHelp_KSJ.Location = new System.Drawing.Point(1506, 12);
            this.buttonHelp_KSJ.Name = "buttonHelp_KSJ";
            this.buttonHelp_KSJ.Size = new System.Drawing.Size(115, 76);
            this.buttonHelp_KSJ.TabIndex = 4;
            this.buttonHelp_KSJ.Text = "Справка";
            this.buttonHelp_KSJ.UseVisualStyleBackColor = true;
            this.buttonHelp_KSJ.Click += new System.EventHandler(this.buttonHelp_KSJ_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 888);
            this.Controls.Add(this.groupBoxTask_KSJ);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 10 | Коева С.Ю";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxTask_KSJ.ResumeLayout(false);
            this.groupBoxTask_KSJ.PerformLayout();
            this.groupBoxResult_.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KSJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxTask_KSJ;
        private System.Windows.Forms.GroupBox groupBoxResult_;
        private System.Windows.Forms.TextBox textBoxTask_KSJ;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KSJ;
        private System.Windows.Forms.Button buttonHelp_KSJ;
        private System.Windows.Forms.Button buttonOpen_KSJ;
        private System.Windows.Forms.Button buttonDone_KSJ;
        private System.Windows.Forms.DataGridView dataGridViewResult_KSJ;
    }
}

