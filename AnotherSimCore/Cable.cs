using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherSimCore
{
    public class Cable
    {
        public int FirstNode { get; }
        public int SecondNode { get; }
        public bool isAlive { get; private set; }

        public void toBreak()
        {
            isAlive = false;
        }
        public Cable(int first, int second) {
            if (first == second)
                throw new Exception("first == second");
            FirstNode = first;
            SecondNode = second;
            isAlive = true;
        }
    }
}
