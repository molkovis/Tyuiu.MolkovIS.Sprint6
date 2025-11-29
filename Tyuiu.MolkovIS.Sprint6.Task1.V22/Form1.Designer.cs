namespace Tyuiu.MolkovIS.Sprint6.Task1.V22
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
            groupBoxCondition_MIS = new GroupBox();
            label1 = new Label();
            groupBoxOutput_MIS = new GroupBox();
            textBoxOutput_MIS = new TextBox();
            labelResult_MIS = new Label();
            groupBoxInput_MIS = new GroupBox();
            textBoxInput2_MIS = new TextBox();
            textBoxInput1_MIS = new TextBox();
            labelInputEnd_MIS = new Label();
            labelInputFirst_MIS = new Label();
            buttonCompute_MIS = new Button();
            buttonHelp_MIS = new Button();
            groupBoxCondition_MIS.SuspendLayout();
            groupBoxOutput_MIS.SuspendLayout();
            groupBoxInput_MIS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_MIS
            // 
            groupBoxCondition_MIS.Controls.Add(label1);
            groupBoxCondition_MIS.Location = new Point(12, 12);
            groupBoxCondition_MIS.Name = "groupBoxCondition_MIS";
            groupBoxCondition_MIS.Size = new Size(403, 157);
            groupBoxCondition_MIS.TabIndex = 0;
            groupBoxCondition_MIS.TabStop = false;
            groupBoxCondition_MIS.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(284, 15);
            label1.TabIndex = 0;
            label1.Text = "Протабулировать f(x) = 3 * x + 2 - (2*x-x)/(cos(x)+1)";
            // 
            // groupBoxOutput_MIS
            // 
            groupBoxOutput_MIS.Controls.Add(textBoxOutput_MIS);
            groupBoxOutput_MIS.Controls.Add(labelResult_MIS);
            groupBoxOutput_MIS.Location = new Point(443, 12);
            groupBoxOutput_MIS.Name = "groupBoxOutput_MIS";
            groupBoxOutput_MIS.Size = new Size(256, 312);
            groupBoxOutput_MIS.TabIndex = 1;
            groupBoxOutput_MIS.TabStop = false;
            groupBoxOutput_MIS.Text = "Вывод";
            // 
            // textBoxOutput_MIS
            // 
            textBoxOutput_MIS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOutput_MIS.Location = new Point(6, 37);
            textBoxOutput_MIS.Multiline = true;
            textBoxOutput_MIS.Name = "textBoxOutput_MIS";
            textBoxOutput_MIS.ReadOnly = true;
            textBoxOutput_MIS.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_MIS.Size = new Size(236, 269);
            textBoxOutput_MIS.TabIndex = 1;
            // 
            // labelResult_MIS
            // 
            labelResult_MIS.AutoSize = true;
            labelResult_MIS.Location = new Point(6, 19);
            labelResult_MIS.Name = "labelResult_MIS";
            labelResult_MIS.Size = new Size(63, 15);
            labelResult_MIS.TabIndex = 0;
            labelResult_MIS.Text = "Результат:";
            // 
            // groupBoxInput_MIS
            // 
            groupBoxInput_MIS.Controls.Add(textBoxInput2_MIS);
            groupBoxInput_MIS.Controls.Add(textBoxInput1_MIS);
            groupBoxInput_MIS.Controls.Add(labelInputEnd_MIS);
            groupBoxInput_MIS.Controls.Add(labelInputFirst_MIS);
            groupBoxInput_MIS.Location = new Point(12, 175);
            groupBoxInput_MIS.Name = "groupBoxInput_MIS";
            groupBoxInput_MIS.Size = new Size(403, 78);
            groupBoxInput_MIS.TabIndex = 2;
            groupBoxInput_MIS.TabStop = false;
            groupBoxInput_MIS.Text = "Ввод";
            // 
            // textBoxInput2_MIS
            // 
            textBoxInput2_MIS.Location = new Point(153, 37);
            textBoxInput2_MIS.Name = "textBoxInput2_MIS";
            textBoxInput2_MIS.Size = new Size(100, 23);
            textBoxInput2_MIS.TabIndex = 6;
            // 
            // textBoxInput1_MIS
            // 
            textBoxInput1_MIS.Location = new Point(6, 37);
            textBoxInput1_MIS.Name = "textBoxInput1_MIS";
            textBoxInput1_MIS.Size = new Size(100, 23);
            textBoxInput1_MIS.TabIndex = 5;
            // 
            // labelInputEnd_MIS
            // 
            labelInputEnd_MIS.AutoSize = true;
            labelInputEnd_MIS.Location = new Point(149, 19);
            labelInputEnd_MIS.Name = "labelInputEnd_MIS";
            labelInputEnd_MIS.Size = new Size(41, 15);
            labelInputEnd_MIS.TabIndex = 4;
            labelInputEnd_MIS.Text = "Конец";
            // 
            // labelInputFirst_MIS
            // 
            labelInputFirst_MIS.AutoSize = true;
            labelInputFirst_MIS.Location = new Point(6, 19);
            labelInputFirst_MIS.Name = "labelInputFirst_MIS";
            labelInputFirst_MIS.Size = new Size(38, 15);
            labelInputFirst_MIS.TabIndex = 3;
            labelInputFirst_MIS.Text = "Старт";
            // 
            // buttonCompute_MIS
            // 
            buttonCompute_MIS.Location = new Point(233, 259);
            buttonCompute_MIS.Name = "buttonCompute_MIS";
            buttonCompute_MIS.Size = new Size(182, 59);
            buttonCompute_MIS.TabIndex = 3;
            buttonCompute_MIS.Text = "Вычислить";
            buttonCompute_MIS.UseVisualStyleBackColor = true;
            buttonCompute_MIS.Click += buttonCompute_MIS_Click;
            // 
            // buttonHelp_MIS
            // 
            buttonHelp_MIS.Location = new Point(12, 259);
            buttonHelp_MIS.Name = "buttonHelp_MIS";
            buttonHelp_MIS.Size = new Size(172, 59);
            buttonHelp_MIS.TabIndex = 4;
            buttonHelp_MIS.Text = "Справка";
            buttonHelp_MIS.UseVisualStyleBackColor = true;
            buttonHelp_MIS.Click += buttonHelp_MIS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 336);
            Controls.Add(buttonHelp_MIS);
            Controls.Add(buttonCompute_MIS);
            Controls.Add(groupBoxInput_MIS);
            Controls.Add(groupBoxOutput_MIS);
            Controls.Add(groupBoxCondition_MIS);
            Name = "Form1";
            Text = "Спринт 6 | таск 1 | Вариант 22 | Мольков И. С.";
            groupBoxCondition_MIS.ResumeLayout(false);
            groupBoxCondition_MIS.PerformLayout();
            groupBoxOutput_MIS.ResumeLayout(false);
            groupBoxOutput_MIS.PerformLayout();
            groupBoxInput_MIS.ResumeLayout(false);
            groupBoxInput_MIS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_MIS;
        private Label label1;
        private GroupBox groupBoxOutput_MIS;
        private GroupBox groupBoxInput_MIS;
        private Label labelResult_MIS;
        private Label labelInputEnd_MIS;
        private Label labelInputFirst_MIS;
        private TextBox textBoxOutput_MIS;
        private TextBox textBoxInput2_MIS;
        private TextBox textBoxInput1_MIS;
        private Button buttonCompute_MIS;
        private Button buttonHelp_MIS;
    }
}
