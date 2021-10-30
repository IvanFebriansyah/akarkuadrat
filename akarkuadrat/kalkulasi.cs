using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akarkuadrat
{
    class kalkulasi
    {
        public double x1, x2, a;
        public string hasil1;
        

        public void hitung()
        {

            
            x2 = a;

            do
            {
                x1 = x2;
                x2 = 0.5 * (x1 + (a / x2));
            } while (x1 != x2);


            hasil1 = x1.ToString();

        }



    }
}
