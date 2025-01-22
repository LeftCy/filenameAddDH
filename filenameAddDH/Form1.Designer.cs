namespace filenameAddDH
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBoxFileNames = new TextBox();
            textBoxFolderPath = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "フォルダパスを入力";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 1;
            label2.Text = "複製対象ファイル名を入力";
            // 
            // button1
            // 
            button1.Location = new Point(713, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "実行";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxFileNames
            // 
            textBoxFileNames.Location = new Point(12, 96);
            textBoxFileNames.Name = "textBoxFileNames";
            textBoxFileNames.Size = new Size(695, 23);
            textBoxFileNames.TabIndex = 4;
            textBoxFileNames.TextChanged += textBoxFileNames_TextChanged;
            // 
            // textBoxFolderPath
            // 
            textBoxFolderPath.Location = new Point(12, 27);
            textBoxFolderPath.Name = "textBoxFolderPath";
            textBoxFolderPath.Size = new Size(695, 23);
            textBoxFolderPath.TabIndex = 5;
            textBoxFolderPath.TextChanged += textBoxFolderPath_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 131);
            Controls.Add(textBoxFolderPath);
            Controls.Add(textBoxFileNames);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBoxFileNames;
        private TextBox textBoxFolderPath;
    }
}
