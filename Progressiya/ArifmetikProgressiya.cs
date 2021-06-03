using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressiya
{
    class ArifmetikProgressiya:ProgressiyaC
    {
        public ArifmetikProgressiya(double birinchiHad,double ayirma)
        {
            this.Ayirma = ayirma;
            this.BirinchiHad = birinchiHad;
        }
        public override double Sum(double n)
        {
            double res = 0;
            for (int i = 0; i <=n; i++)
            {
                res += BirinchiHad + i * Ayirma;
            }
            return base.Sum(res); 
        }
        public double ProgressHad(int hadIndex)
        {
            return BirinchiHad + Ayirma * hadIndex;
        }
    }
}
