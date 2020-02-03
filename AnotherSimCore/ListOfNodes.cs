using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherSimCore
{
    public class ListOfNodes
    {
        List<Node> allNodes = new List<Node>();

        public void Add(Node node)
        {
            allNodes.Add(node);
        }
        public Node GetNodeById(int id)
        {
            foreach(Node n in allNodes)
            {
                if (n.Id == id)
                    return n;
            }
            return null;
        }
    }
}
