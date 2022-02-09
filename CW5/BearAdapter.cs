using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5
{
    class BearAdapter : ToyBear
    {
        Bear burr;

        public BearAdapter(Bear argu)
        {
            burr = argu;
        }

        public void hug()
        {
            burr.maul();
        }
    }
}
