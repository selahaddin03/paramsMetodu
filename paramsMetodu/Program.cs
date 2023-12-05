using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsMetodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayıIslemlerı si = new SayıIslemlerı();
            Console.WriteLine("toplam:{0}",si.toplam(3));
            Console.WriteLine("toplam:{0}",si.toplam(3,4,5));
            Console.WriteLine("toplam:{0}",si.toplam(5,1,7,3,4,5));
        }
    }
    class SayıIslemlerı
    {
        public  int toplam(params int[] sayilar)
        {
            int toplam = 0;
            foreach(var s in sayilar)
            {
                toplam += s;
            }
            return toplam;
        }
    }
}
