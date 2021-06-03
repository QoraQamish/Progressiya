using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressiya
{
    public abstract class ProgressiyaC
    {
        public double BirinchiHad { get; set; }
        public double Ayirma { get; set; }
        public virtual double Sum(double n)
        {
            return n;
        }
       
    }
}
