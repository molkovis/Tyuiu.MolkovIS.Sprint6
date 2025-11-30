namespace Tyuiu.MolkovIS.Sprint6.Task4.V17
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
            groupBoxCondition = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chartOutput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult = new TextBox();
            groupBoxInput = new GroupBox();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            label3 = new Label();
            label2 = new Label();
            buttonDone = new Button();
            button2 = new Button();
            buttonHelp = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            groupBoxCondition.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartOutput).BeginInit();
            groupBoxInput.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(label1);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(331, 100);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(22, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 496);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // chartOutput
            // 
            chartArea1.Name = "ChartArea1";
            chartOutput.ChartAreas.Add(chartArea1);
            chartOutput.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartOutput.Legends.Add(legend1);
            chartOutput.Location = new Point(0, 0);
            chartOutput.Name = "chartOutput";
            chartOutput.Size = new Size(773, 563);
            chartOutput.TabIndex = 1;
            chartOutput.Text = "chart1";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ButtonShadow;
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 19);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(324, 474);
            textBoxResult.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxStop);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Controls.Add(label3);
            groupBoxInput.Controls.Add(label2);
            groupBoxInput.Location = new Point(349, 12);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(420, 100);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(152, 54);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 3;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 54);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 19);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 1;
            label3.Text = "конец";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Старт";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.IndianRed;
            buttonDone.Location = new Point(775, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(105, 100);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(886, 12);
            button2.Name = "button2";
            button2.Size = new Size(102, 100);
            button2.TabIndex = 4;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(1212, 22);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(80, 81);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(12, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 553);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(chartOutput);
            panel4.Location = new Point(466, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(773, 563);
            panel4.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 683);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(buttonHelp);
            Controls.Add(button2);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxCondition);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartOutput).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBoxInput;
        private Label label3;
        private Label label2;
        private Button buttonDone;
        private Button button2;
        private Button buttonHelp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutput;
        private TextBox textBoxResult;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Panel panel1;
        private Panel panel4;
    }
}
