using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Counter
    {
        private int value;
        int scaleFactor;
        public Counter(int sF)
        {
            this.scaleFactor = sF;
        }
        public void Inc()
        {
            value += scaleFactor;
        }
        public int Count
        {
            get { return value; }
        }
     }
}
