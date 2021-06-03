using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressiya
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("___________Arifmetik progressiya_______\n Dastlabki hadni kiriting");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Progressiya ayirmasi");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Progressiyaning nechinchi hadi kerak?");
            int n = int.Parse(Console.ReadLine());
            ArifmetikProgressiya progressiya = new ArifmetikProgressiya(a, d);
            Console.WriteLine("Hadning qiymati an:{0}",progressiya.ProgressHad(n));
            Console.WriteLine("Progressiya yig'indisi Sn={0}",progressiya.Sum(n));

            Console.WriteLine("___________Giometrik progressiya________");
            Console.WriteLine("Dastlabki qiymatni kirting");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Progressiya ayirmasi");
            double q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Progressiyaning nechinchi hadi kerak?");
            int bn = int.Parse(Console.ReadLine());
            GiometrikProgressiya giometrik = new GiometrikProgressiya(b, q);
            if (q>1)
            {
                Console.WriteLine("Ushbu giometrik progressiya o'suvchi");
            }
            else
            {
                Console.WriteLine("Ushbu giometrik progressiya kamayuvchi");
            }
            Console.WriteLine("Hadning qiymati an:{0}", giometrik.Bn(n));
            Console.WriteLine("Progressiya yig'indisi Sn={0}", giometrik.Sum(n));

            Console.ReadKey();

        }
    }
}
