namespace FileRewriter_Threading_
{
    partial class Form1
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
            this.OldItem = new System.Windows.Forms.TextBox();
            this.NewItem = new System.Windows.Forms.TextBox();
            this.ChoosedFile = new System.Windows.Forms.TextBox();
            this.ExecutionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBReplaceAll = new System.Windows.Forms.CheckBox();
            this.CBReplaceWords = new System.Windows.Forms.CheckBox();
            this.path_to_file_label = new System.Windows.Forms.Label();
            this.new_word_label = new System.Windows.Forms.Label();
            this.old_word_label = new System.Windows.Forms.Label();
            this.ResentFilesListBox = new System.Windows.Forms.ListBox();
            this.resent_files_label = new System.Windows.Forms.Label();
            this.RBIgnore = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OldItem
            // 
            this.OldItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OldItem.Location = new System.Drawing.Point(84, 60);
            this.OldItem.Name = "OldItem";
            this.OldItem.Size = new System.Drawing.Size(103, 20);
            this.OldItem.TabIndex = 15;
            this.OldItem.TextChanged += new System.EventHandler(this.OldItem_TextChanged);
            // 
            // NewItem
            // 
            this.NewItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NewItem.Location = new System.Drawing.Point(243, 60);
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(108, 20);
            this.NewItem.TabIndex = 14;
            this.NewItem.TextChanged += new System.EventHandler(this.NewItem_TextChanged);
            // 
            // ChoosedFile
            // 
            this.ChoosedFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ChoosedFile.Location = new System.Drawing.Point(84, 8);
            this.ChoosedFile.Name = "ChoosedFile";
            this.ChoosedFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChoosedFile.Size = new System.Drawing.Size(267, 20);
            this.ChoosedFile.TabIndex = 13;
            this.ChoosedFile.TextChanged += new System.EventHandler(this.ChoosedFile_TextChanged);
            // 
            // ExecutionButton
            // 
            this.ExecutionButton.Location = new System.Drawing.Point(387, 60);
            this.ExecutionButton.Name = "ExecutionButton";
            this.ExecutionButton.Size = new System.Drawing.Size(115, 20);
            this.ExecutionButton.TabIndex = 16;
            this.ExecutionButton.Text = "Execute";
            this.ExecutionButton.UseVisualStyleBackColor = true;
            this.ExecutionButton.Click += new System.EventHandler(this.ExecutionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "File name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Replace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "with";
            // 
            // CBReplaceAll
            // 
            this.CBReplaceAll.AutoSize = true;
            this.CBReplaceAll.Checked = true;
            this.CBReplaceAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBReplaceAll.Location = new System.Drawing.Point(394, 8);
            this.CBReplaceAll.Name = "CBReplaceAll";
            this.CBReplaceAll.Size = new System.Drawing.Size(107, 17);
            this.CBReplaceAll.TabIndex = 20;
            this.CBReplaceAll.Text = "replace all strings";
            this.CBReplaceAll.UseVisualStyleBackColor = true;
            // 
            // CBReplaceWords
            // 
            this.CBReplaceWords.AutoSize = true;
            this.CBReplaceWords.Location = new System.Drawing.Point(394, 31);
            this.CBReplaceWords.Name = "CBReplaceWords";
            this.CBReplaceWords.Size = new System.Drawing.Size(113, 17);
            this.CBReplaceWords.TabIndex = 21;
            this.CBReplaceWords.Text = "replase words only";
            this.CBReplaceWords.UseVisualStyleBackColor = true;
            // 
            // path_to_file_label
            // 
            this.path_to_file_label.AutoSize = true;
            this.path_to_file_label.BackColor = System.Drawing.Color.White;
            this.path_to_file_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.path_to_file_label.Location = new System.Drawing.Point(90, 11);
            this.path_to_file_label.Name = "path_to_file_label";
            this.path_to_file_label.Size = new System.Drawing.Size(65, 13);
            this.path_to_file_label.TabIndex = 32;
            this.path_to_file_label.Text = "/path/to/file";
            // 
            // new_word_label
            // 
            this.new_word_label.AutoSize = true;
            this.new_word_label.BackColor = System.Drawing.Color.White;
            this.new_word_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.new_word_label.Location = new System.Drawing.Point(249, 63);
            this.new_word_label.Name = "new_word_label";
            this.new_word_label.Size = new System.Drawing.Size(53, 13);
            this.new_word_label.TabIndex = 33;
            this.new_word_label.Text = "new word";
            // 
            // old_word_label
            // 
            this.old_word_label.AutoSize = true;
            this.old_word_label.BackColor = System.Drawing.Color.White;
            this.old_word_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.old_word_label.Location = new System.Drawing.Point(90, 64);
            this.old_word_label.Name = "old_word_label";
            this.old_word_label.Size = new System.Drawing.Size(47, 13);
            this.old_word_label.TabIndex = 34;
            this.old_word_label.Text = "old word";
            // 
            // ResentFilesListBox
            // 
            this.ResentFilesListBox.FormattingEnabled = true;
            this.ResentFilesListBox.HorizontalScrollbar = true;
            this.ResentFilesListBox.Items.AddRange(new object[] {
            "D:\\USERS\\Buhrii_B\\C#\\Навчальна практика\\FileRewriter\\wine_db.txt",
            "D:\\USERS\\Buhrii_B\\C#\\Навчальна практика\\FileRewriter\\house_db.txt"});
            this.ResentFilesListBox.Location = new System.Drawing.Point(10, 129);
            this.ResentFilesListBox.Name = "ResentFilesListBox";
            this.ResentFilesListBox.Size = new System.Drawing.Size(507, 134);
            this.ResentFilesListBox.TabIndex = 35;
            this.ResentFilesListBox.SelectedIndexChanged += new System.EventHandler(this.ResentFilesListBox_SelectedIndexChanged);
            // 
            // resent_files_label
            // 
            this.resent_files_label.AutoSize = true;
            this.resent_files_label.Location = new System.Drawing.Point(13, 106);
            this.resent_files_label.Name = "resent_files_label";
            this.resent_files_label.Size = new System.Drawing.Size(65, 13);
            this.resent_files_label.TabIndex = 37;
            this.resent_files_label.Text = "Resent files:";
            // 
            // RBIgnore
            // 
            this.RBIgnore.AutoSize = true;
            this.RBIgnore.Location = new System.Drawing.Point(450, 97);
            this.RBIgnore.Name = "RBIgnore";
            this.RBIgnore.Size = new System.Drawing.Size(48, 17);
            this.RBIgnore.TabIndex = 38;
            this.RBIgnore.TabStop = true;
            this.RBIgnore.Text = "ignor";
            this.RBIgnore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 272);
            this.Controls.Add(this.RBIgnore);
            this.Controls.Add(this.resent_files_label);
            this.Controls.Add(this.ResentFilesListBox);
            this.Controls.Add(this.old_word_label);
            this.Controls.Add(this.new_word_label);
            this.Controls.Add(this.path_to_file_label);
            this.Controls.Add(this.CBReplaceWords);
            this.Controls.Add(this.CBReplaceAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExecutionButton);
            this.Controls.Add(this.OldItem);
            this.Controls.Add(this.NewItem);
            this.Controls.Add(this.ChoosedFile);
            this.Name = "Form1";
            this.Text = "FileRewriter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldItem;
        private System.Windows.Forms.TextBox NewItem;
        private System.Windows.Forms.TextBox ChoosedFile;
        private System.Windows.Forms.Button ExecutionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CBReplaceAll;
        private System.Windows.Forms.CheckBox CBReplaceWords;
        private System.Windows.Forms.Label path_to_file_label;
        private System.Windows.Forms.Label new_word_label;
        private System.Windows.Forms.Label old_word_label;
        private System.Windows.Forms.ListBox ResentFilesListBox;
        private System.Windows.Forms.Label resent_files_label;
        private System.Windows.Forms.RadioButton RBIgnore;
    }
}

