namespace Tyuiu.MolkovIS.Sprint6.Task5.V21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonInfo = new Button();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            groupBoxCondition_MIS = new GroupBox();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            dataGridView_MIS = new DataGridView();
            chart_MIS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            groupBoxCondition_MIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MIS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_MIS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(groupBoxCondition_MIS);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 132);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(814, 27);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(103, 85);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(665, 27);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(143, 85);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Посмотреть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(529, 23);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(130, 89);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxCondition_MIS
            // 
            groupBoxCondition_MIS.Controls.Add(label1);
            groupBoxCondition_MIS.Location = new Point(12, 12);
            groupBoxCondition_MIS.Name = "groupBoxCondition_MIS";
            groupBoxCondition_MIS.Size = new Size(511, 100);
            groupBoxCondition_MIS.TabIndex = 0;
            groupBoxCondition_MIS.TabStop = false;
            groupBoxCondition_MIS.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "ВЫполнить задание";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 132);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView_MIS);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(chart_MIS);
            splitContainer1.Size = new Size(1089, 475);
            splitContainer1.SplitterDistance = 306;
            splitContainer1.TabIndex = 1;
            // 
            // dataGridView_MIS
            // 
            dataGridView_MIS.AllowUserToAddRows = false;
            dataGridView_MIS.AllowUserToDeleteRows = false;
            dataGridView_MIS.AllowUserToResizeColumns = false;
            dataGridView_MIS.AllowUserToResizeRows = false;
            dataGridView_MIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_MIS.Dock = DockStyle.Fill;
            dataGridView_MIS.Location = new Point(0, 0);
            dataGridView_MIS.Name = "dataGridView_MIS";
            dataGridView_MIS.RowHeadersVisible = false;
            dataGridView_MIS.ScrollBars = ScrollBars.Vertical;
            dataGridView_MIS.Size = new Size(306, 475);
            dataGridView_MIS.TabIndex = 0;
            // 
            // chart_MIS
            // 
            chartArea1.Name = "ChartArea1";
            chart_MIS.ChartAreas.Add(chartArea1);
            chart_MIS.Dock = DockStyle.Fill;
            chart_MIS.Location = new Point(0, 0);
            chart_MIS.Name = "chart_MIS";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart_MIS.Series.Add(series1);
            chart_MIS.Size = new Size(779, 475);
            chart_MIS.TabIndex = 0;
            chart_MIS.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 607);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBoxCondition_MIS.ResumeLayout(false);
            groupBoxCondition_MIS.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_MIS).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_MIS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView_MIS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MIS;
        private Button buttonInfo;
        private Button buttonOpenFile;
        private Button buttonDone;
        private GroupBox groupBoxCondition_MIS;
        private Label label1;
    }
}
