using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherSimCore
{
    public class Cable
    {
        public Node FirstNode { get; }
        public Node SecondNode { get; }
        public bool isAlive { get; private set; }

        public void toBreak()
        {
            isAlive = false;
        }
        public Cable(Node first, Node second) {
            if (first == second)
                throw new Exception("first == second");
            FirstNode = first;
            SecondNode = second;
            isAlive = true;
        }
    }
}
