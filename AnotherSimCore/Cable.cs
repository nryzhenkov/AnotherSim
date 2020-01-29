using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherSimCore
{
    public class Cable
    {
        Node firstNode;
        Node secondNode;
        public bool isAlive { get; private set; }
        public Cable(Node first, Node second) {
            firstNode = first;
            secondNode = second;
            isAlive = true;
        }
    }
}
