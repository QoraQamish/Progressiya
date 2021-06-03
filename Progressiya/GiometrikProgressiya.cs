using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressiya
{
    public class GiometrikProgressiya:ProgressiyaC
    {
        public GiometrikProgressiya(double b,double q)
        {
            this.BirinchiHad = b;
            this.Ayirma = q;
        }
        public override double Sum(double n)
        {
            double res = BirinchiHad * (1 - Math.Pow(Ayirma, n - 1))/ (1 - Ayirma);
            
            return base.Sum(res);
        }
        public double Bn(int n)
        {
            return BirinchiHad * Math.Pow(Ayirma, n - 1);
        }
    }
}
