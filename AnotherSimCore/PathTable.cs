using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherSimCore
{
    public class PathTable
    {
        Dictionary<Node, Node> path = new Dictionary<Node, Node>();

        public void Add(Node destination, Node to)
        {
            path.Add(destination, to);
        }

        public Node GetNextNode(Node destination)
        {
            return path[destination];
        }
    }
}
