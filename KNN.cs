using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningSystem
{
    public class KNN
    {
        public List<List<Tuple<string, double>>> sorteazaDistanaDupaIndex(ref List<List<double>> temp, int k)
        {
            List<List<Tuple<string, double>>> tuples = new List<List<Tuple<string, double>>>();

            for (var i = 0; i < temp.Count; i++)
            {
                tuples.Add(new List<Tuple<string, double>>());
                for (var j = 0; j < temp[i].Count; j++)
                {
                    tuples[i].Add(new Tuple<string, double>(Form1.claseTraining[j], temp[i][j]));
                }

                tuples[i] = tuples[i].OrderBy(t => t.Item2).ToList();
                tuples[i].RemoveRange(k, tuples[i].Count - k);
            }

            return tuples;
        } 
    }
}
