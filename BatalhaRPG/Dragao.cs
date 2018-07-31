using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaRPG
{
    class Dragao : Chefe
    {


        public Dragao(int vida) : base(vida)
        {     
            
        }

        public int mordida()
        {
            return 20;
        }

        public int bolaDeFogo()
        {
            return 30;
        }

        public int arranhao()
        {
            return 15;
        }


    }
}
