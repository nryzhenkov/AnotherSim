using System;
using System.Collections.Generic;

namespace AnotherSimCore
{
    public class Node
    {
        public int Id { get; }
        Cable connectedCable;
        List<Message> storeMessage = new List<Message>();
        PathTable path = new PathTable();
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

        private void AddNextNode()
        {
            if(connectedCable != null)
                path.Add(connectedCable.SecondNode, connectedCable.SecondNode);
        }
        public void toSend()
        {
            Message msg = findFirstMessageForSend();
            if(msg != null)
            {
                // TODO: realization functional of transport message 
            }
            DeleteMessgae(msg);
        }

        void DeleteMessgae(Message msg)
        {
            storeMessage.Remove(msg);
        }
        Message findFirstMessageForSend()
        {
            foreach(Message msg in storeMessage)
            {
                if (msg.FromNode == this)
                    return msg;
            }
            return null;
        }
        public void toRecive(Message msg)
        {
            storeMessage.Add(msg);
        }

        public void createMessage(Node idDestination, string text)
        {
            if (idDestination == this)
                throw new Exception("idDestination == Id");
            Message msg = new Message(this, idDestination);
            msg.Text = text;
            storeMessage.Add(msg);
        }

    }
}
