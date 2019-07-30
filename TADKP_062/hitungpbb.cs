using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADKP_062
{
    class hitungpbb
    {
        double njkphitungpbb;
        double pajakfix = 0.005f;
        double hasilpbb;

        public void hitungpbbnya(double njkpcls)
        {
            njkphitungpbb = njkpcls;
            hasilpbb = njkpcls * pajakfix;
        }
        public double hasilhitungpbb()
        {
            return Math.Round(hasilpbb);
        }
    }
}