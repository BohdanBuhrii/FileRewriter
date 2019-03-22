using System;
using System.IO;
using System.Text;

namespace FileRewriter_Threading_
{
    static class Loger
    {
        //static class

        private static readonly string pathToLogFile = @"D:\USERS\Buhrii_B\C#\Навчальна практика\FileRewriter\_Programs which work\logs.txt";
        private static StreamWriter logStream;


        static Loger()
        {
            logStream = new StreamWriter(pathToLogFile, true);
        }

        public static void MakeLog(string message)
        {
            lock (logStream)
            {
                logStream.WriteLine("<" + DateTime.Now.ToString() + ">  " + message);
                logStream.Flush();
            }
        }
    }
}
