using System.Threading;
using System.IO;
using System;


namespace FileRewriter_Threading_
{
    partial class Form1 : IDisposable
    {
        public void RewriteFile(string path, string oldWord, string newWord, Replacer.Replace replace)
        {
            new Thread(() =>
            {
                if (File.Exists(path))
                {
                    Loger.MakeLog("start working with "+path);

                    string[] lines = File.ReadAllLines(path);
                    int linesNumber= lines.Length;

                    LoadForm loadForm = new LoadForm();
                    loadForm.FileNameLabel.Text = path;
                    loadForm.progressBar.Maximum = linesNumber; 

                    loadForm.Show();
                    loadForm.Refresh();

                    
                    for (int i=0; i < linesNumber; i++)
                    {
                        lines[i] = replace(lines[i], oldWord, newWord);
                        lines[i] += " ";
                        i++;

                        loadForm.progressBar.Value += 1;
                        Thread.Sleep(1);//для наочності
                    }


                    File.WriteAllLines(path.Insert(path.LastIndexOf("."), "(Copy)"), lines);

                    Loger.MakeLog("data saved in "+path.Insert(path.LastIndexOf("."), "(Copy)"));

                    while (loadForm.progressBar.Value < loadForm.progressBar.Maximum)
                    {
                        loadForm.progressBar.Value += 1;    
                    }
                    
                    loadForm.CloseButton.Visible = true;
                    loadForm.Visible=false;
                    loadForm.ShowDialog();
                    
                    loadForm.Dispose();
                }
                else throw new Exception("Error: File not found");
            }).Start();
        }

        /*public FileInfo this[string path]
        {
            get
            {
                return files[files.IndexOf(new FileInfo(path))];
            }
        }*/

        public new void Dispose()
        {
            /*foreach (Thread thread in threads)
            {
                if (thread.IsAlive) thread.Abort();
            }*/

            GC.SuppressFinalize(this);
        }
    }
}
    
