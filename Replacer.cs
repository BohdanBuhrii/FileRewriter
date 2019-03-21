

namespace FileRewriter_Threading_
{
    public static class Replacer
    {
        public delegate string Replace(string line, string oldWord, string newWord);


        public static string ReplaceAllStrings(string line, string oldWord, string newWord)
        {
            int oldWordIndex;
            while (line.Contains(oldWord))
            {
                oldWordIndex = line.IndexOf(oldWord);

                line = line.Remove(oldWordIndex, oldWord.Length);

                line = line.Insert(oldWordIndex, newWord);
            }
            return line;
        }


        public static string ReplaceWords(string line, string oldWord, string newWord)
        {
            string newLine = "";
            char[] separators = new char[] { ' ', ',', '.', '!', '?', ':', ';' };
            string[] words = line.Split(separators);
            foreach (string word in words)
            {
                if (word == oldWord)
                {
                    newLine += newWord;
                }
                else newLine += word;
            }
            return newLine;
        }

    }
}
