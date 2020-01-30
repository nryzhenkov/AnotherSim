using System;
using System.Collections.Generic;

namespace AnotherSimCore
{
    public class Node
    {
        public int Id { get; }
        Cable connectedCable;
        List<Message> storeMessage = new List<Message>();
        public Cable ConnectedCable
        {
            get { return connectedCable; }
            set
            {
                if (value.FirstNode != value.SecondNode)
                    connectedCable = value;
                else
                    throw new Exception("first == second");
            }
        }
        public Node(int id)
        {
            Id = id;
        }



    }
}
