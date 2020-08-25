using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrog
{
    class FrogController
    {
        Frog frog = new Frog();

        public void growFrog()
        {
            frog.grow();
        }

        public void shrinkFrog()
        {
            frog.shrink();
        }

        public int getFrogSize()
        {
            return frog.getSize();
        }


    }
}
