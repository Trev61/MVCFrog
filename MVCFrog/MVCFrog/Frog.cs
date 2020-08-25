using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrog
{
    class Frog
    {
        int size = 0;

        public void grow()
        {
            size++;
            if (size > 1000)
            {
                size = 1000;
            }
        }

        public void shrink()
        {
            size--;
            if (size < 0)
            {
                size = 0;
            }
        }

        public int getSize()
        {
            return size;
        }
    }
}
