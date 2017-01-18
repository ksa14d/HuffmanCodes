using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{

    class Huffman
    {
        Dictionary<string, double> probability = new Dictionary<string, double>() {
{"A", 0.08149},
{"B", 0.01439},
{"C", 0.02757},
{"D", 0.03787},
{"E", 0.13101},
{"F", 0.02923},
{"G", 0.01993},
{"H", 0.05257},
{"I", 0.06344},
{"J", 0.00132},
{"K", 0.00420},
{"L", 0.03388},
{"M", 0.02535},
{"N", 0.07096},
{"O", 0.07993},
{"P", 0.01981},
{"Q", 0.00121},
{"R", 0.06880},
{"S", 0.06099},
{"T", 0.10465},
{"U", 0.02458},
{"V", 0.00919},
{"W", 0.01538},
{"X", 0.00166},
{"Y", 0.01982},
{"Z", 0.00077}
        };

        SortedDictionary<double, string> probailitySort = new SortedDictionary<double, string>();

    
        Dictionary<string, double> Huff = new Dictionary<string, double>();
        public void CalculateHuffman()
        {
            foreach(var pr in probability)
            {
                probailitySort.Add(pr.Value, pr.Key);
            }
            
            List<double> sortedvalues = probability.Values.ToList();
            sortedvalues.Sort();
           
            int Step = 0;
            while (sortedvalues.Count > 1)
            {
                Step++;
                string Charac = Step.ToString();
                double min1 = sortedvalues[0];
                if (probability.Values.Contains(min1))
                {
                    Charac += probability.Where(x => x.Value == min1).First().Key;
                }
                double min2 = sortedvalues[1]; ;
                if (probability.Values.Contains(min2))
                {
                    Charac += ",+ "+probability.Where(x => x.Value == min2).First().Key;
                }
                double result = min1 + min2;
                Huff.Add(Charac,result);
                sortedvalues.RemoveRange(0, 2);
                sortedvalues.Add(result);
                sortedvalues.Sort();
            }
        }
    }
}
