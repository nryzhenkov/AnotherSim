using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherSimCore
{
    public class Message
    {
        public int FromNode { get; }
        public int ToNode { get; }
        public string Text { get; set; }


        public Message(int from, int to)
        {
            FromNode = from;
            ToNode = to;
        }
    }
}
