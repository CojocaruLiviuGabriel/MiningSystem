using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MiningSystem
{
    public partial class Form1 : Form
    {
        Article art = new();
        GainCalculation gainCalculation = new();
        WriteFile writeFile = new();
        List<Article> ListaXml = new();
        RareVectors rareVector = new();
        List<Dictionary<int, int>> vectors = new();
        List<Tuple<string, string>> infos = new();
        List<double> gainList = new();
        Dictionary<string, int> topicFreq = new();
        List<Dictionary<int, int>> vectRarTest = new List<Dictionary<int, int>>();
        List<Dictionary<int, int>> vectRarTraining = new List<Dictionary<int, int>>();

        List<string> docInfoTest = new List<string>();
        List<string> docInfoTraining = new List<string>();


        CreateMatrix citire = new();
        Normalizare normalizare = new();
        public static List<string> claseTest, claseTraining, claseUniceTest, claseUniceTraining;
        double[,] dateFisierTest;
        double[,] dateFisierTraining;
        public static int k;
        Distanta distanta = new();
        KNN kNN = new();
        MetriciExterne externe = new MetriciExterne();
        List<List<double>> metrici = new List<List<double>>();
        ConfusionMatrix cn = new ConfusionMatrix();
        Salvare s = new Salvare();
        List<List<double>> distante;
        List<List<Tuple<string, double>>> distanteSortateCuIndex = new List<List<Tuple<string, double>>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSmallDataSet_Click(object sender, EventArgs e)
        {
            ListaXml = art.CheckAndInitiateXMLFiles("Reuters_34");
            vectors = rareVector.CreateGlobalVectorAndRareVectors(ListaXml);
            btnLargeDataSet.Enabled = false;
            btnSmallDataSet.Enabled = false;
            writeFile.WriteExtractedFeaturesToFile(vectors, ListaXml);
            infos = writeFile.getDocInfo();
            List<string> dict = rareVector.getGlobalDictionary();
            gainList = gainCalculation.Gain(vectors, dict, infos);
            MessageBox.Show("Done");
        }

        private void btnLargeDataSet_Click(object sender, EventArgs e)
        {
            ListaXml = art.CheckAndInitiateXMLFiles("Reuters_7083");
            vectors = rareVector.CreateGlobalVectorAndRareVectors(ListaXml);
            btnLargeDataSet.Enabled = false;
            btnSmallDataSet.Enabled = false;
            writeFile.WriteExtractedFeaturesToFile(vectors, ListaXml);
            infos = writeFile.getDocInfo();
            List<string> dict = rareVector.getGlobalDictionary();
            gainList = gainCalculation.Gain(vectors, dict, infos);
            MessageBox.Show("Done");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSf_Click(object sender, EventArgs e)
        {
            
            citire.CitesteFisierArff(out dateFisierTest,"./../../../ArffData/Small_Data_test.arff");
            citire.CitesteFisierArff(out dateFisierTraining,"./../../../ArffData/Small_Data_Training.arff");
            claseTest = citire.ClaseDinFisier("./../../../ArffData/Small_Data_test.arff");
            claseTraining = citire.ClaseDinFisier("./../../../ArffData/Small_Data_Training.arff");
            claseUniceTest = citire.ClaseDinFisierTopiceUnice("./../../../ArffData/Small_Data_test.arff");
            claseUniceTraining = citire.ClaseDinFisierTopiceUnice("./../../../ArffData/Small_Data_Training.arff");
        }

        private void btnLf_Click(object sender, EventArgs e)
        {
            citire.CitesteFisierArff(out dateFisierTest, "./../../../ArffData/Large_Data_test.arff");
            citire.CitesteFisierArff(out dateFisierTraining, "./../../../ArffData/Large_Data_Training.arff");
            claseTest = citire.ClaseDinFisier("./../../../ArffData/Large_Data_test.arff");
            claseTraining = citire.ClaseDinFisier("./../../../ArffData/Large_Data_Training.arff");
            claseUniceTest = citire.ClaseDinFisierTopiceUnice("./../../../ArffData/Large_Data_test.arff");
            claseUniceTraining = citire.ClaseDinFisierTopiceUnice("./../../../ArffData/Large_Data_Training.arff");
        }



        private void btnNormalizare_Click(object sender, EventArgs e)
        {
            if (dateFisierTest == null && dateFisierTraining == null)
            {
                MessageBox.Show("Mai intai trebuie citite datele!");
            }
            else
            {


                if (rbNormB.Checked)
                {
                    normalizare.NormalizareBinara(dateFisierTest);
                    normalizare.NormalizareBinara(dateFisierTraining);
                }
                if (rbNormCS.Checked)
                {
                    normalizare.NormalizareLogaritmDublu(dateFisierTest);
                    normalizare.NormalizareLogaritmDublu(dateFisierTraining);
                }
                if (rbNormNom.Checked)
                {
                    normalizare.NormalizareNominala(dateFisierTest);
                    normalizare.NormalizareNominala(dateFisierTraining);
                }
                if (rbNormSum1.Checked)
                {
                    normalizare.NormalizareSuma1(dateFisierTest);
                    normalizare.NormalizareSuma1(dateFisierTraining);
                }
            }
        }

        private void btnCalcDistante_Click(object sender, EventArgs e)
        {
            if (rbDistE.Checked)
            {
                distante = distanta.DistantaMinkowski(ref dateFisierTest, ref dateFisierTraining, 2);
                MessageBox.Show("Distante calculate!");
            }
            if (rbDisMan.Checked)
            {
                distante = distanta.DistantaMinkowski(ref dateFisierTest, ref dateFisierTraining, 1);
                MessageBox.Show("Distante calculate!");
            }
            if (rbDisMin.Checked)
            {
                distante = distanta.DistantaMinkowski(ref dateFisierTest, ref dateFisierTraining, Convert.ToInt32(nUdMinkOrder.Value));
                MessageBox.Show("Distante calculate!");
            }
            if (rbDistCos.Checked)
            {
                distante = distanta.DistantaCosinus(ref dateFisierTest, ref dateFisierTraining);
                MessageBox.Show("Distante calculate!");
            }
        }

        private void btnKKN_Click(object sender, EventArgs e)
        {
            k = Convert.ToInt32(tbK.Text);
            distanteSortateCuIndex = kNN.sorteazaDistanaDupaIndex(ref distante, k);
            cn.confusionMatrices(claseTest, distanteSortateCuIndex);
            metrici = externe.CalculMetrici(cn.confusionMatrices(claseTest, distanteSortateCuIndex));
            s.WriteOutputData(metrici);
        }

        private void btnGain_Click(object sender, EventArgs e)
        {
            double prag = Convert.ToDouble(nudGain.Value);
            List<string> globalDictionary = rareVector.getGlobalDictionary();

            foreach (double castig in gainList.ToList())
            {
                if (castig < prag)
                {
                    int index = gainList.IndexOf(castig);

                    for (var i = 0; i < vectors.Count(); i++)
                    {
                        vectors[i].Remove(index);
                    }

                    globalDictionary.RemoveAt(index);
                    gainList.RemoveAt(index);

                }
            }

            using (StreamWriter sw = new StreamWriter("./../../../ArffData/Large_SelectiaTrasaturilor.arff"))
            {
                

                for (int i = 0; i < gainList.Count; i++)
                {
                    sw.WriteLine("@attribute atrib" + (i + 1).ToString() + " " + gainList[i]);
                }

                for (int i = 0; i < infos.Count; i++)
                {
                    sw.WriteLine("@topic " + infos[i].Item1);
                }

                sw.WriteLine("\n@data\n");

                for (var i = 0; i < vectors.Count(); i++)
                {
                    string linie = "";
                    int ind = 0;
                    foreach (KeyValuePair<int, int> kvp in vectors[i])
                    {
                        linie = linie + ind.ToString() + ":" + kvp.Value.ToString() + " ";
                        ind++;
                    }
                    linie = linie + "#" + infos[i].Item1 + " #" + infos[i].Item2;
                    sw.WriteLine(linie);

                }
            }
            MessageBox.Show("DONE!");
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vectors.Count; i++)
            {
                if (infos[i].Item2 == "testing")
                {
                    vectRarTest.Add(vectors[i]);
                    docInfoTest.Add(infos[i].Item1);
                }
                else if (infos[i].Item2 == "training")
                {
                    vectRarTraining.Add(vectors[i]);
                    docInfoTraining.Add(infos[i].Item1);
                }
            }
            string temp = string.Join(" ", docInfoTest.ToArray());
            string[] aux = temp.Split(" ");
            aux = aux.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            topicsFrequency(aux);
            using (StreamWriter sw = new StreamWriter("./../../../ArffData/Large_Data_test.arff"))
            {
                sw.Write("#Samples " + vectRarTest.Count() + "\n");
                sw.WriteLine("#Atributtes " + gainList.Count());
                sw.WriteLine("#Topics " + topicFreq.Count + "\n");

                for (int i = 0; i < gainList.Count; i++)
                {
                    sw.WriteLine("@attribute atrib" + (i + 1).ToString() + " " + Math.Round(gainList[i],2));
                }
                foreach(var entry in topicFreq)
                {
                    sw.WriteLine("@topic " + entry.Key + " " + entry.Value.ToString());
                }

                sw.WriteLine("\n@data\n");

                for (var i = 0; i < vectRarTest.Count(); i++)
                {
                    string linie = "";

                    int ind = 0;
                    foreach (KeyValuePair<int, int> kvp in vectRarTest[i])
                    {
                        linie = linie + ind.ToString() + ":" + kvp.Value.ToString() + " ";
                        ind++;
                    }

                    linie = linie + "#" + docInfoTest[i];
                    sw.WriteLine(linie);

                }
            }
            //------------------------------------------------------------------------------------------
            string tempTraining = string.Join(" ", docInfoTraining.ToArray());
            string[] auxTraining = tempTraining.Split(" ");
            auxTraining = auxTraining.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            topicsFrequency(auxTraining);
            using (StreamWriter sw = new StreamWriter("./../../../ArffData/Large_Data_Training.arff"))
            {
                sw.Write("#Samples " + vectRarTraining.Count() + "\n");
                sw.WriteLine("#Atributtes " + gainList.Count());
                sw.WriteLine("#Topics " + topicFreq.Count + "\n");

                for (int i = 0; i < gainList.Count; i++)
                {
                    sw.WriteLine("@attribute atrib" + (i + 1).ToString() + " " + Math.Round(gainList[i], 2));
                }
                foreach (var entry in topicFreq)
                {
                    sw.WriteLine("@topic " + entry.Key + " " + entry.Value.ToString());
                }

                sw.WriteLine("\n@data\n");

                for (var i = 0; i < vectRarTraining.Count(); i++)
                {
                    string linie = "";

                    int ind = 0;
                    foreach (KeyValuePair<int, int> kvp in vectRarTraining[i])
                    {
                        linie = linie + ind.ToString() + ":" + kvp.Value.ToString() + " ";
                        ind++;
                    }

                    linie = linie + "#" + docInfoTraining[i];
                    sw.WriteLine(linie);

                }
            }

            MessageBox.Show("Split data done!");
        }

        private void topicsFrequency(string[] infos)
        {
            for(int i = 0; i < infos.Length; i++)
            {
                if(topicFreq.ContainsKey(infos[i]))
                {
                    topicFreq.TryGetValue(infos[i], out int tempValue);
                    topicFreq[infos[i]] = tempValue + 1;
                }
                else
                {
                    topicFreq.Add(infos[i], 1);
                }
            }
        }
    }
}
