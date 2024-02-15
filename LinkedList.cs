namespace Sq20.Net_Week4_Task
{
    public class LinkedList<T> : Node<T>
    {
        private int listSize;
        public int AddElement(T Element)
        {
            var node = new Node<T> { Tvalue = Element };
            if (NodeHead == null)
            {
                NodeHead = node;
            }
            else
            {
                var currentNode = NodeHead;
                while (currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.NextNode = node;
            }
            listSize++;
            return listSize;

        }

        public bool RemoveElement(T Element)
        {
            var node = new Node<T> { Tvalue = Element };
            if (NodeHead == null)
                return false;

            if (NodeHead == node)
            {
                NodeHead = NextNode;
                listSize--;
                return true;
            }
            else
            {
                var currentNode = NodeHead;
                while (currentNode.NextNode != null)
                {
                    if (currentNode.NextNode == node)
                    {
                        currentNode.NextNode = currentNode.NextNode.NextNode;
                        /*currentNode = currentNode.NextNode;
                        currentNode = currentNode.NextNode;*/
                        listSize--;
                        return true;
                    }
                    currentNode = currentNode.NextNode;
                }

                return false;
            }


        }

        public bool CheckElement(T Element)
        {
            var node = new Node<T> { Tvalue = Element };
            var currentNode = NodeHead;
            while (currentNode != null)
            {
                if (currentNode == node)
                    return true;
                currentNode = currentNode.NextNode;
            }
            return false;
        }

        public int IndexOfanElement(T Element)
        {
            var node = new Node<T> { Tvalue = Element };
            var currentNode = NodeHead;
            int index = 0;
            while (currentNode != null)
            {
                if (currentNode == node)
                    return index;
                currentNode = currentNode.NextNode;
                index++;
            }
            return -1;
        }

        public bool IsEmpty()
        {
            return listSize == 0;
        }



    }
}
