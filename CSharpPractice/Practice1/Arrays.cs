using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class DeclareArraysSample
    {
        int v;
        public DeclareArraysSample() { }
        //public DeclareArraysSample(int a)
        //{
        //    if
        //}
        public void arraySample()
        {
            int[] numbers = new int[5];
            string[,] names = new string[5, 4];
            byte[][] scores = new byte[v][];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            }
        }
    }
}
