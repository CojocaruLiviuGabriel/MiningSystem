using System;
using System.Collections.Generic;

namespace MiningSystem
{
    public class GainCalculation
    {
         
        public List<double> Gain(List<Dictionary<int,int>> vectRar,List<string> globalDictionary, List<Tuple<string, string>> docInfo)
        {
            List<double> gainList = new List<double>();
            List<Tuple<double, double>> entropyWordInClass = EntropyWordInClass(globalDictionary,vectRar,docInfo);
            List<Tuple<double, double>> entropyWordNotInClass = EntropyWordNotInClass(globalDictionary,vectRar,docInfo);
            double totalEntropy = EntropieTotala(docInfo);

            foreach (var word in globalDictionary)
            {
                int index = globalDictionary.IndexOf(word);
                double inClass = (entropyWordInClass[index].Item2 / (entropyWordInClass[index].Item2 + entropyWordNotInClass[index].Item2)) * entropyWordInClass[index].Item1;
                double notInClass = (entropyWordNotInClass[index].Item2 / (entropyWordInClass[index].Item2 + entropyWordNotInClass[index].Item2)) * entropyWordNotInClass[index].Item1;
                double gain = totalEntropy - inClass - notInClass;
                gainList.Add(gain);
            }
            return gainList;
        }

        public List<Tuple<double, double>> EntropyWordInClass(List<string> globalDict,List<Dictionary<int,int>> vectRar,List<Tuple<string, string>> dataInfo)
        {
            List<Tuple<double, double>> entropyList = new List<Tuple<double, double>>();

            foreach (var word in globalDict)
            {
                Dictionary<string, int> tempDictionary = new Dictionary<string, int>();
                int key = globalDict.IndexOf(word);
                int count = 0; //de cate ori apare cuvantul in toate documentele

                foreach (var doc in vectRar)
                {
                    if (doc.ContainsKey(key))
                    {

                        int indexDoc = vectRar.IndexOf(doc);

                        if (tempDictionary.ContainsKey(dataInfo[indexDoc].Item1))
                        {
                            tempDictionary.TryGetValue(dataInfo[indexDoc].Item1, out int tempValue);
                            tempDictionary[dataInfo[indexDoc].Item1] = tempValue + 1;
                            count++;

                        }
                        else
                        {
                            tempDictionary.Add(dataInfo[indexDoc].Item1, 1);
                            count++;
                        }
                    }
                }

                entropyList.Add(Tuple.Create(Entropy(tempDictionary, count), Convert.ToDouble(count)));
            }

            return entropyList;

        }

        public List<Tuple<double, double>> EntropyWordNotInClass(List<string> globalDict,List<Dictionary<int, int>> vectRar,List<Tuple<string, string>> dataInfo)
        {
            List<Tuple<double, double>> entropyList = new List<Tuple<double, double>>();
            


            foreach (var word in globalDict)
            {
                Dictionary<string, int> tempDictionary = new Dictionary<string, int>();
                int key = globalDict.IndexOf(word);
                int count = 0; //de cate ori apare cuvantul in toate documentele

                foreach (var doc in vectRar)
                {
                    if (!doc.ContainsKey(key))
                    {
                        int indexDoc = vectRar.IndexOf(doc);

                        if (tempDictionary.ContainsKey(dataInfo[indexDoc].Item1))
                        {
                            tempDictionary.TryGetValue(dataInfo[indexDoc].Item1, out int tempValue);
                            tempDictionary[dataInfo[indexDoc].Item1] = tempValue + 1;
                            count++;

                        }
                        else
                        {
                            tempDictionary.Add(dataInfo[indexDoc].Item1, 1);
                            count++;
                        }
                    }
                }
                entropyList.Add(Tuple.Create(Entropy(tempDictionary, count), Convert.ToDouble(count)));
            }

            return entropyList;

        }

        public double EntropieTotala(List<Tuple<string, string>> dataInfo)
        {
            Dictionary<string, int> classRepartization = new Dictionary<string, int>();

            foreach (var info in dataInfo)
            {
                string keyClass = info.Item1;
                if (classRepartization.ContainsKey(keyClass))
                {
                    classRepartization.TryGetValue(keyClass, out int tempValue);
                    classRepartization[keyClass] = tempValue + 1;
                }
                else
                {
                    classRepartization.Add(keyClass, 1);

                }
            }

            return Entropy(classRepartization, dataInfo.Count);
        }

        public double Entropy(Dictionary<string, int> classRepartization, double totalElements)
        {
            double valEntropie = 0;
            foreach (KeyValuePair<string, int> kvp in classRepartization)
            {
                double logarithm = Math.Log(((double)kvp.Value / totalElements), 2);
                valEntropie -= kvp.Value / totalElements * logarithm;
            }

            return valEntropie;
        }


    }
}
