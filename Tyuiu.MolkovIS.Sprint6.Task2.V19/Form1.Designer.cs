namespace Tyuiu.MolkovIS.Sprint6.Task2.V19
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxCondition = new GroupBox();
            label1 = new Label();
            groupBoxoutput = new GroupBox();
            dataGridViewResult = new DataGridView();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            groupBoxInput = new GroupBox();
            textBoxInput2 = new TextBox();
            textBoxInput1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxCondition.SuspendLayout();
            groupBoxoutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(label1);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(322, 138);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 0;
            label1.Text = "Протабулировать функцию";
            // 
            // groupBoxoutput
            // 
            groupBoxoutput.Controls.Add(dataGridViewResult);
            groupBoxoutput.Controls.Add(chartResult);
            groupBoxoutput.Controls.Add(label2);
            groupBoxoutput.Location = new Point(340, 12);
            groupBoxoutput.Name = "groupBoxoutput";
            groupBoxoutput.Size = new Size(953, 426);
            groupBoxoutput.TabIndex = 1;
            groupBoxoutput.TabStop = false;
            groupBoxoutput.Text = "Вывод";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.AllowUserToDeleteRows = false;
            dataGridViewResult.AllowUserToResizeColumns = false;
            dataGridViewResult.AllowUserToResizeRows = false;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(6, 37);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Size = new Size(295, 350);
            dataGridViewResult.TabIndex = 2;
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(319, 37);
            chartResult.Name = "chartResult";
            chartResult.Size = new Size(603, 350);
            chartResult.TabIndex = 1;
            chartResult.Text = "График функции";
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartResult.Titles.Add(title1);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Результат";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxInput2);
            groupBoxInput.Controls.Add(textBoxInput1);
            groupBoxInput.Controls.Add(label4);
            groupBoxInput.Controls.Add(label3);
            groupBoxInput.Location = new Point(12, 156);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(322, 102);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // textBoxInput2
            // 
            textBoxInput2.Location = new Point(128, 53);
            textBoxInput2.Name = "textBoxInput2";
            textBoxInput2.Size = new Size(100, 23);
            textBoxInput2.TabIndex = 3;
            // 
            // textBoxInput1
            // 
            textBoxInput1.Location = new Point(6, 53);
            textBoxInput1.Name = "textBoxInput1";
            textBoxInput1.Size = new Size(100, 23);
            textBoxInput1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 19);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 1;
            label4.Text = "Конец";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "Старт";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(33, 287);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(74, 131);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(184, 296);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(150, 112);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Вычислить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxoutput);
            Controls.Add(groupBoxCondition);
            Name = "Form1";
            Text = "Form1";
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxoutput.ResumeLayout(false);
            groupBoxoutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private GroupBox groupBoxoutput;
        private GroupBox groupBoxInput;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBoxInput2;
        private TextBox textBoxInput1;
        private Button buttonHelp;
        private Button buttonDone;
        private DataGridView dataGridViewResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
    }
}
