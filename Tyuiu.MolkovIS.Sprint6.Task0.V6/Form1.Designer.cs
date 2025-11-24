namespace Tyuiu.MolkovIS.Sprint6.Task0.V6
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
            PictureBox pictureBoxCondition_MolkovIS;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxCondition_MolkovIS = new TextBox();
            textBoxA_MolkovIS = new TextBox();
            groupBoxInputs_MolkovIS = new GroupBox();
            labelA_MolkovIS = new Label();
            groupBoxOutput_MolkovIS = new GroupBox();
            textBoxResult_MIS = new TextBox();
            buttonResult_MolkovIS = new Button();
            pictureBoxCondition_MolkovIS = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_MolkovIS).BeginInit();
            groupBoxInputs_MolkovIS.SuspendLayout();
            groupBoxOutput_MolkovIS.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCondition_MolkovIS
            // 
            pictureBoxCondition_MolkovIS.Image = (Image)resources.GetObject("pictureBoxCondition_MolkovIS.Image");
            pictureBoxCondition_MolkovIS.Location = new Point(447, 56);
            pictureBoxCondition_MolkovIS.Name = "pictureBoxCondition_MolkovIS";
            pictureBoxCondition_MolkovIS.Size = new Size(188, 96);
            pictureBoxCondition_MolkovIS.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCondition_MolkovIS.TabIndex = 1;
            pictureBoxCondition_MolkovIS.TabStop = false;
            // 
            // textBoxCondition_MolkovIS
            // 
            textBoxCondition_MolkovIS.AccessibleName = "";
            textBoxCondition_MolkovIS.BorderStyle = BorderStyle.FixedSingle;
            textBoxCondition_MolkovIS.Location = new Point(23, 38);
            textBoxCondition_MolkovIS.Multiline = true;
            textBoxCondition_MolkovIS.Name = "textBoxCondition_MolkovIS";
            textBoxCondition_MolkovIS.ReadOnly = true;
            textBoxCondition_MolkovIS.Size = new Size(400, 114);
            textBoxCondition_MolkovIS.TabIndex = 0;
            textBoxCondition_MolkovIS.Tag = "";
            textBoxCondition_MolkovIS.Text = "Условие:\r\nВычислить выражение по формуле";
            // 
            // textBoxA_MolkovIS
            // 
            textBoxA_MolkovIS.Location = new Point(7, 49);
            textBoxA_MolkovIS.Name = "textBoxA_MolkovIS";
            textBoxA_MolkovIS.Size = new Size(100, 23);
            textBoxA_MolkovIS.TabIndex = 2;
            textBoxA_MolkovIS.KeyPress += textBoxA_MolkovIS_KeyPress;
            // 
            // groupBoxInputs_MolkovIS
            // 
            groupBoxInputs_MolkovIS.Controls.Add(labelA_MolkovIS);
            groupBoxInputs_MolkovIS.Controls.Add(textBoxA_MolkovIS);
            groupBoxInputs_MolkovIS.Location = new Point(23, 174);
            groupBoxInputs_MolkovIS.Name = "groupBoxInputs_MolkovIS";
            groupBoxInputs_MolkovIS.Size = new Size(134, 98);
            groupBoxInputs_MolkovIS.TabIndex = 3;
            groupBoxInputs_MolkovIS.TabStop = false;
            groupBoxInputs_MolkovIS.Text = "Ввод данных";
            // 
            // labelA_MolkovIS
            // 
            labelA_MolkovIS.AutoSize = true;
            labelA_MolkovIS.Location = new Point(7, 31);
            labelA_MolkovIS.Name = "labelA_MolkovIS";
            labelA_MolkovIS.Size = new Size(70, 15);
            labelA_MolkovIS.TabIndex = 5;
            labelA_MolkovIS.Text = "Значение X";
            // 
            // groupBoxOutput_MolkovIS
            // 
            groupBoxOutput_MolkovIS.Controls.Add(textBoxResult_MIS);
            groupBoxOutput_MolkovIS.Location = new Point(179, 174);
            groupBoxOutput_MolkovIS.Name = "groupBoxOutput_MolkovIS";
            groupBoxOutput_MolkovIS.Size = new Size(133, 62);
            groupBoxOutput_MolkovIS.TabIndex = 4;
            groupBoxOutput_MolkovIS.TabStop = false;
            groupBoxOutput_MolkovIS.Text = "Вывод данных";
            // 
            // textBoxResult_MIS
            // 
            textBoxResult_MIS.Location = new Point(15, 22);
            textBoxResult_MIS.Name = "textBoxResult_MIS";
            textBoxResult_MIS.ReadOnly = true;
            textBoxResult_MIS.Size = new Size(100, 23);
            textBoxResult_MIS.TabIndex = 0;
            // 
            // buttonResult_MolkovIS
            // 
            buttonResult_MolkovIS.Location = new Point(194, 242);
            buttonResult_MolkovIS.Name = "buttonResult_MolkovIS";
            buttonResult_MolkovIS.Size = new Size(88, 23);
            buttonResult_MolkovIS.TabIndex = 5;
            buttonResult_MolkovIS.Text = "Вычислить";
            buttonResult_MolkovIS.UseVisualStyleBackColor = true;
            buttonResult_MolkovIS.Click += buttonResult_MolkovIS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 286);
            Controls.Add(buttonResult_MolkovIS);
            Controls.Add(groupBoxOutput_MolkovIS);
            Controls.Add(groupBoxInputs_MolkovIS);
            Controls.Add(pictureBoxCondition_MolkovIS);
            Controls.Add(textBoxCondition_MolkovIS);
            Name = "Form1";
            Text = "Спринт 6 | таск 0 | Вариант 6 | Мольков И. С.";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_MolkovIS).EndInit();
            groupBoxInputs_MolkovIS.ResumeLayout(false);
            groupBoxInputs_MolkovIS.PerformLayout();
            groupBoxOutput_MolkovIS.ResumeLayout(false);
            groupBoxOutput_MolkovIS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCondition_MolkovIS;
        private TextBox textBoxA_MolkovIS;
        private GroupBox groupBoxInputs_MolkovIS;
        private Label labelA_MolkovIS;
        private GroupBox groupBoxOutput_MolkovIS;
        private TextBox textBoxResult_MIS;
        private Button buttonResult_MolkovIS;
    }
}
