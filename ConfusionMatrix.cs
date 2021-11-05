using System;
using System.Collections.Generic;
using System.Linq;


namespace MiningSystem
{
    public class ConfusionMatrix
    {
        //clasa reala - DA
        private double TruePositive; //clasa predicitonata DA
        private double FalseNegative; //clasa predicitonata NU

        //clasa reala - NU
        private double FalsePositive; //clasa predicitonata DA
        private double TrueNegative; //clasa predicitonata NU

        string[] clasa;
        public double TP { get => TruePositive; set => TruePositive = value; }
        public double FN { get => FalseNegative; set => FalseNegative = value; }
        public double FP { get => FalsePositive; set => FalsePositive = value; }
        public double TN { get => TrueNegative; set => TrueNegative = value; }

        public ConfusionMatrix(double truePositive, double falseNegative, double falsePositive, double trueNegative)
        {
            TruePositive = truePositive;
            FalseNegative = falseNegative;
            FalsePositive = falsePositive;
            TrueNegative = trueNegative;
        }

        public ConfusionMatrix() { }
        public ConfusionMatrix[] confusionMatrices(List<string> clasaReala, List<List<Tuple<string, double>>> distantaSortataCuClasa)
        {
            //array cu matrici de eroare
            ConfusionMatrix[] matriciDeEroare = new ConfusionMatrix[Form1.claseUniceTraining.Count];

            freq(freqClase(distantaSortataCuClasa));
            //Initializare matrici de eroare pentru clase
            for (int i = 0; i < Form1.claseUniceTraining.Count; i++)
            {
                matriciDeEroare[i] = new ConfusionMatrix(0, 0, 0, 0);
            }


            for (int i = 0; i < distantaSortataCuClasa.Count; i++)
            {
                for (int j = 0; j < Form1.claseUniceTraining.Count; j++)
                {

                    if (Form1.claseUniceTraining[j].Equals(clasaReala[i]))
                    {
                        if (clasaReala[i].Equals(clasa[i]))
                        {
                            matriciDeEroare[j].TP++;
                        }
                        else
                        {
                            matriciDeEroare[j].FN++;
                        }
                    }
                    else
                    {
                        if (Form1.claseUniceTraining[j].Equals(clasa[i]))
                        {
                            matriciDeEroare[j].FP++;
                        }
                        else
                        {
                            matriciDeEroare[j].TN++;
                        }
                    }


                }
            }

            return matriciDeEroare;
        }

        public List<List<string>> freqClase(List<List<Tuple<string, double>>> distantaSortataCuClasa)
        {
            List<List<string>> t = new List<List<string>>();
            for (int i = 0; i < distantaSortataCuClasa.Count; i++)
            {
                t.Add(new List<string>());
                for (int j = 0; j < distantaSortataCuClasa[i].Count; j++)
                {

                    t[i].Add(distantaSortataCuClasa[i][j].Item1);
                }
            }

            return t;
        }

        public void freq(List<List<string>> t)
        {
            string[] cts = new string[t.Count];
            int[] fcts = new int[t.Count];
            List<Dictionary<string, int>> contorClase = new List<Dictionary<string, int>>();
            for (int i = 0; i < t.Count; i++)
            {
                contorClase.Add(new Dictionary<string, int>());
                for (int j = 0; j < t[i].Count; j++)
                {
                    if (contorClase[i].ContainsKey(t[i][j]))
                    {
                        int temp = contorClase[i][t[i][j]];
                        contorClase[i][t[i][j]] = ++temp;
                    }
                    else
                    {
                        contorClase[i][t[i][j]] = 1;
                    }
                }
            }

            clasa = new string[Form1.claseTest.Count];
            for (var i = 0; i < contorClase.Count; i++)
            {
                for (var j = 0; j < contorClase[i].Count; j++)
                {
                    var m = contorClase[i].OrderByDescending(x => x.Value).FirstOrDefault().Key;
                    clasa[i] = m;
                }
            }
        }

        public bool checkIfAllElementsAreEqual(int[] freqArr)
        {
            int first = freqArr[0];

            if (freqArr.Length > 1)
            {
                for (int i = 1; i < freqArr.Length; i++)
                {
                    if (freqArr[i] != first)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
