using System.Collections.Generic;
using Factorio_guide__WPF;

namespace Factorio_guide__WPF
{
    public class TotalRaw
    {

        public double Time { get; set; }

        public List<IntermediateProducts> Products{get; set; }
        
        public TotalRaw(double time, List<IntermediateProducts> products = null)
        {
            Time = time;
            Products = products;
        }
    }
}