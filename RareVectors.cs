using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiningSystem
{
    public class RareVectors
    {
        private List<string> stopwords = new();
        public List<string> globalDictionary = new();
        private readonly PorterStemmer porterStemmer = new();
        public string[] GetWords(string input)
        {
            MatchCollection matches = Regex.Matches(input, @"\b[^\d\W]+\b");

            var words = from m in matches.Cast<Match>()
                        where !string.IsNullOrEmpty(m.Value)
                        select TrimSuffix(m.Value);

            return words.ToArray();
        }

        public string TrimSuffix(string word)
        {
            int apostropheLocation = word.IndexOf('\'');
            if (apostropheLocation != -1)
            {
                word = word.Substring(0, apostropheLocation);
            }

            return word;
        }

        public void ReadFileInList(out List<string> lines, string filePath)
        {
            lines = new List<string>();
            string line;
            StreamReader file = new StreamReader(filePath);

            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);

            }
        }

        public bool IsStopword(string word)
        {

            foreach (string s in stopwords)
            {
                if (s == word)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsInGlobalDictionary(string word)
        {
            foreach (string str in globalDictionary)
            {
                if (str == word)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOfTheWordInGlobalDictionary(string word)
        {
            return (globalDictionary.IndexOf(word));
        }

        public void RareVector(Dictionary<int, int> dictionary, int key)
        {

            if (dictionary.ContainsKey(key))
            {
                dictionary.TryGetValue(key, out int tempValue);
                dictionary[key] = tempValue + 1;
            }
            else
            {
                dictionary.Add(key, 1);
            }

        }

        public List<Dictionary<int, int>> CreateGlobalVectorAndRareVectors(List<Article> articleList)
        {
            List<Dictionary<int, int>> vectoriRari = new List<Dictionary<int, int>>();

            string filePath = @"./../../../InputData/stopwords.txt";
            ReadFileInList(out stopwords, filePath); 


            foreach (Article article in articleList)
            {
                Dictionary<int, int> tempDictionary = new Dictionary<int, int>();
                //Dictionary<string, int> stringDict = new Dictionary<string, int>();
                string[] titleWords = GetWords(article.getTitle());
                string[] textWords = GetWords(article.getText());
                string[] completeText = titleWords.Concat(textWords).ToArray();
                
                foreach (string str in completeText)
                {
                    if (IsStopword(str) == false)
                    {
                        string wordRoot = porterStemmer.StemWord(str);
                        if (!IsInGlobalDictionary(wordRoot))
                        {
                            globalDictionary.Add(wordRoot);
                        }
 
                        int indexGlobalDictionary = IndexOfTheWordInGlobalDictionary(wordRoot);
                        RareVector(tempDictionary, indexGlobalDictionary);

                    }
                }

                vectoriRari.Add(tempDictionary);
            }

            return vectoriRari;
        }

        public List<string> getGlobalDictionary()
        {
            return globalDictionary;
        }
    }
}
