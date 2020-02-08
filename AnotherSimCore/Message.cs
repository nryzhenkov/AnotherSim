using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherSimCore
{
    public class Message
    {
        public Node FromNode { get; }
        public Node ToNode { get; }
        public string Text { get; set; }


        public Message(Node from, Node to)
        {
            FromNode = from;
            ToNode = to;
        }
    }
}
