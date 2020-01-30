using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherSimCore
{
    public class Message
    {
        int fromNode;
        int toNode;
        public string Text { get; set; }


        public Message(int from, int to)
        {
            fromNode = from;
            toNode = to;
        }
    }
}
