namespace Tyuiu.MolkovIS.Sprint6.Task6.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            GroupBoxCondition = new GroupBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBoxOutput = new GroupBox();
            textBoxOutput = new TextBox();
            groupBoxInput = new GroupBox();
            textBoxInput = new TextBox();
            openFileDialog = new OpenFileDialog();
            panel1.SuspendLayout();
            GroupBoxCondition.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 70);
            panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonHelp.Location = new Point(797, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 64);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDone.Location = new Point(93, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(88, 64);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOpenFile.Location = new Point(12, 3);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 64);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "Открыть";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // GroupBoxCondition
            // 
            GroupBoxCondition.Controls.Add(label1);
            GroupBoxCondition.Dock = DockStyle.Top;
            GroupBoxCondition.Location = new Point(0, 70);
            GroupBoxCondition.Name = "GroupBoxCondition";
            GroupBoxCondition.Size = new Size(884, 93);
            GroupBoxCondition.TabIndex = 1;
            GroupBoxCondition.TabStop = false;
            GroupBoxCondition.Text = "Условие";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(878, 71);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBoxOutput, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBoxInput, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 163);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(884, 398);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutput);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(445, 3);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(436, 392);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод: ";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.Location = new Point(3, 19);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(430, 370);
            textBoxOutput.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxInput);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(3, 3);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(436, 392);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод: ";
            // 
            // textBoxInput
            // 
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Location = new Point(3, 19);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(430, 370);
            textBoxInput.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(GroupBoxCondition);
            Controls.Add(panel1);
            MinimumSize = new Size(600, 400);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "спринт 6 таск 6 вариант 18";
            panel1.ResumeLayout(false);
            GroupBoxCondition.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonHelp;
        private Button buttonDone;
        private Button buttonOpenFile;
        private GroupBox GroupBoxCondition;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxOutput;
        private TextBox textBoxOutput;
        private GroupBox groupBoxInput;
        private TextBox textBoxInput;
        private OpenFileDialog openFileDialog;
    }
}
