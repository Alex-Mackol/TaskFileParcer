using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using TaskFileParcer.Models.InterfaceModel;

namespace TaskFileParcer.Models.ClassModel
{
    class Parcer : ICountWords, IChangeString
    {
        public string Link { get; set; }
        public string WordToCount { get; set; }
        public string StringToFind { get; set; }
        public string StringToChange { get; set; }

        public Parcer(string link, string wordToCount)
        {
            Link = link;
            WordToCount = wordToCount;
        }
        public Parcer(string link, string stringToFind, string stringToChange)
        {
            Link = link;
            StringToFind = stringToFind;
            StringToChange = stringToChange;
        }

        public void ChangeStrings()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Link);
            try
            {
                string newFileName = directoryInfo.Name;

                using (Stream stream = new FileStream(@".\newText.txt", FileMode.OpenOrCreate))
                {
                    using (StreamWriter write = new StreamWriter(stream, Encoding.UTF8))
                    {
                        foreach (string gettedLine in GetString())
                        {
                            write.WriteLine(gettedLine.Replace(StringToFind, StringToChange));
                        }
                    }
                }

                if (File.Exists(Link))
                {
                    File.Delete(Link);
                }

                File.Move(@".\newText.txt", newFileName);
            }
            catch (IOException ex)
            {
                throw ex;
            }

        }

        public int FindAmountOfWord()
        {
            int amountOfWords = 0;
            foreach (string gettedLine in GetString())
            {
                if (gettedLine.Contains(WordToCount))
                {
                    amountOfWords++;
                }
            }
            return amountOfWords;
        }

        public IEnumerable<string> GetString()
        {
            string line = "";
            using (StreamReader reader = new StreamReader(Link))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }

        }
    }
}
