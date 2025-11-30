namespace Tyuiu.MolkovIS.Sprint6.Task3.V4
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
            groupBoxData_MIS = new GroupBox();
            groupBoxOutput_MIS = new GroupBox();
            label1 = new Label();
            dataGridViewInput_MIS = new DataGridView();
            dataGridViewOutput_MIS = new DataGridView();
            buttonDone_MIS = new Button();
            button2 = new Button();
            groupBoxData_MIS.SuspendLayout();
            groupBoxOutput_MIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_MIS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MIS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxData_MIS
            // 
            groupBoxData_MIS.Controls.Add(dataGridViewInput_MIS);
            groupBoxData_MIS.Controls.Add(label1);
            groupBoxData_MIS.Location = new Point(12, 12);
            groupBoxData_MIS.Name = "groupBoxData_MIS";
            groupBoxData_MIS.Size = new Size(418, 249);
            groupBoxData_MIS.TabIndex = 0;
            groupBoxData_MIS.TabStop = false;
            groupBoxData_MIS.Text = "Условие";
            // 
            // groupBoxOutput_MIS
            // 
            groupBoxOutput_MIS.Controls.Add(dataGridViewOutput_MIS);
            groupBoxOutput_MIS.Location = new Point(436, 12);
            groupBoxOutput_MIS.Name = "groupBoxOutput_MIS";
            groupBoxOutput_MIS.Size = new Size(239, 249);
            groupBoxOutput_MIS.TabIndex = 1;
            groupBoxOutput_MIS.TabStop = false;
            groupBoxOutput_MIS.Text = "Вывод";
            // 
            // label1
            // 
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(201, 66);
            label1.TabIndex = 0;
            label1.Text = "Заменить четные элементы второй строки на 0";
            // 
            // dataGridViewInput_MIS
            // 
            dataGridViewInput_MIS.AllowUserToAddRows = false;
            dataGridViewInput_MIS.AllowUserToDeleteRows = false;
            dataGridViewInput_MIS.AllowUserToResizeColumns = false;
            dataGridViewInput_MIS.AllowUserToResizeRows = false;
            dataGridViewInput_MIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_MIS.Location = new Point(213, 22);
            dataGridViewInput_MIS.Name = "dataGridViewInput_MIS";
            dataGridViewInput_MIS.Size = new Size(199, 221);
            dataGridViewInput_MIS.TabIndex = 1;
            // 
            // dataGridViewOutput_MIS
            // 
            dataGridViewOutput_MIS.AllowUserToAddRows = false;
            dataGridViewOutput_MIS.AllowUserToDeleteRows = false;
            dataGridViewOutput_MIS.AllowUserToResizeColumns = false;
            dataGridViewOutput_MIS.AllowUserToResizeRows = false;
            dataGridViewOutput_MIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_MIS.Location = new Point(20, 22);
            dataGridViewOutput_MIS.Name = "dataGridViewOutput_MIS";
            dataGridViewOutput_MIS.Size = new Size(199, 221);
            dataGridViewOutput_MIS.TabIndex = 2;
            // 
            // buttonDone_MIS
            // 
            buttonDone_MIS.Location = new Point(508, 261);
            buttonDone_MIS.Name = "buttonDone_MIS";
            buttonDone_MIS.Size = new Size(104, 43);
            buttonDone_MIS.TabIndex = 2;
            buttonDone_MIS.Text = "Выполнить";
            buttonDone_MIS.UseVisualStyleBackColor = true;
            buttonDone_MIS.Click += buttonDone_MIS_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 271);
            button2.Name = "button2";
            button2.Size = new Size(33, 23);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 316);
            Controls.Add(button2);
            Controls.Add(buttonDone_MIS);
            Controls.Add(groupBoxOutput_MIS);
            Controls.Add(groupBoxData_MIS);
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Спринт 6 | таск 3 | Вариант 4 | Мольков И. С.";
            Load += Form1_Load;
            groupBoxData_MIS.ResumeLayout(false);
            groupBoxOutput_MIS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_MIS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MIS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxData_MIS;
        private DataGridView dataGridViewInput_MIS;
        private Label label1;
        private GroupBox groupBoxOutput_MIS;
        private DataGridView dataGridViewOutput_MIS;
        private Button buttonDone_MIS;
        private Button button2;
    }
}
