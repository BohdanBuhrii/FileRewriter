using System;
using System.IO;
using System.Windows.Forms;

namespace FileRewriter_Threading_
{
    public partial class Form1 : Form
    {

        /*private void CreateFolderTree()
        {
        }*/

        public Form1()
        {
            InitializeComponent();
        }


        private void ExecutionButton_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(ChoosedFile.Text))
            {
                ResentFilesListBox.Items.Add(ChoosedFile.Text);
                
                if (CBReplaceAll.Checked)
                {
                    RewriteFile(ChoosedFile.Text, OldItem.Text, NewItem.Text, Replacer.ReplaceAllStrings);
                }
                else if (CBReplaceWords.Checked)
                {
                    RewriteFile(ChoosedFile.Text, OldItem.Text, NewItem.Text, Replacer.ReplaceWords);
                }
                else
                {
                    MessageBox.Show("Please, choose prorerties");
                }
                
            }
            else MessageBox.Show("Oops, " + ChoosedFile.Text + " not found");
        }
        

        private void ChoosedFile_TextChanged(object sender, EventArgs e)
        {
            path_to_file_label.Visible = false;
            
            //ChoosedFile.ForeColor = System.Drawing.SystemColors.WindowText;  //як зробити щоб виконува-
        }                                                                    //лось лише один раз?

        private void OldItem_TextChanged(object sender, EventArgs e)
        {
            old_word_label.Visible = false;
            //OldItem.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void NewItem_TextChanged(object sender, EventArgs e)
        {
            new_word_label.Visible = false;
            //NewItem.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void ResentFilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChoosedFile.Text = ResentFilesListBox.SelectedItem.ToString();
        }

        
        /*
        private void LoadFormButton_Click(object sender, EventArgs e)
        {
            LoadForm loadForm = new LoadForm();
            
            loadForm.Show();

            loadForm.progressBar.Value = 25;
            loadForm.FileNameLabel.Text = "qwerty";
            //loadForm.Show();
            //loadForm.ShowDialog();
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //FolderTree.Nodes.Add(new TreeNode("root"));
    }
}
