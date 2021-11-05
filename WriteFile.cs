using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MiningSystem
{
    public class WriteFile
    {
        List<Tuple<string, string>> docInfo = new List<Tuple<string, string>>();
        public void WriteExtractedFeaturesToFile(List<Dictionary<int, int>> vectRar, List<Article> ListaXml)
        {
            using (StreamWriter fisier = new StreamWriter(@"./../../../Output/trasaturiExtraseFisiereXML_Reuters7083.txt"))
            {
                for (var i = 0; i < vectRar.Count(); i++)
                {
                    string linie;
                    if (i == 0)
                    {
                        linie = "@data\n\n";
                    }
                    else
                    {
                        linie = "";
                    }
                    foreach (KeyValuePair<int, int> kvp in vectRar[i])
                    {
                        linie = linie + kvp.Key.ToString() + ":" + kvp.Value.ToString() + " ";
                    }
                    List<string> temp = ListaXml[i].getClassCodes();
                    string clase = string.Empty;
                    for(int j = 0; j < temp.Count; j++)
                    {
                        clase = clase + " " + temp[j];
                    }
                    linie = linie + "#";
                    foreach (string v in temp)
                    {
                        linie = linie + " " + v;
                    }
                    linie = linie + " # " + ListaXml[i].getDataSet();
                    docInfo.Add(Tuple.Create(clase, ListaXml[i].getDataSet()));
                    fisier.WriteLine(linie);

                }
            }
        }

        public List<Tuple<string,string>> getDocInfo()
        {
            return docInfo;
        }
    }
}
