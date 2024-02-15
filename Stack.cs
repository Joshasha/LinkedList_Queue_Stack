namespace Sq20.Net_Week4_Task
{
    public class Stack<T> : Node<T>
    {

        private int stackSize;

        public Stack()
        {
            NodeHead = null;
            stackSize = 0;
        }

        public bool IsEmpty()
        {
            return NodeHead == null;
        }

        public void Push(T Element)
        {
            var node = new Node<T> { Tvalue = Element, NextNode = NodeHead };
            NodeHead = node;
            stackSize++;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            T Element = NodeHead.Tvalue;
            NodeHead = NodeHead.NextNode;
            stackSize--;
            return Element;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return NodeHead.Tvalue;
        }

        public int Size()
        {
            return stackSize;
        }
    }
}
