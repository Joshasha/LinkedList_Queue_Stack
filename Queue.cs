namespace Sq20.Net_Week4_Task
{
    public class Queue<T> : Node<T>
    {
        private int queueSize;
        public Queue()
        {
            NodeHead = null;
            NodeTail = null;
            queueSize = 0;
        }

        public bool IsEmpty()
        {
            return NodeHead == null;
        }

        public void Enqueue(T Element)
        {
            var node = new Node<T> { Tvalue = Element, NextNode = null };
            if (IsEmpty())
            {
                NodeHead = node;
                NodeTail = node;
            }
            else
            {
                NodeTail.NextNode = node;
                NodeTail = node;
            }
            queueSize++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            T Element = NodeHead.Tvalue;
            NodeHead = NodeHead.NextNode;
            if (NodeHead == null)
                NodeTail = null;
            queueSize--;
            return Element;
        }

        public int Size()
        {
            return queueSize;
        }
    }
}
