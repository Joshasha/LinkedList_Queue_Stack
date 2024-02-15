namespace Sq20.Net_Week4_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Queue methods execution
            Console.WriteLine("Queue methods execution:");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Queue size: " + queue.Size()); // Output: 3
            Console.WriteLine("Dequeued element: " + queue.Dequeue()); // Output: 1
            Console.WriteLine("Dequeued element: " + queue.Dequeue()); // Output: 2
            Console.WriteLine("Is queue empty? " + queue.IsEmpty()); // Output: False
            Console.WriteLine();

            // Stack methods execution
            Console.WriteLine("Stack methods executions:");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Stack size: " + stack.Size()); // Output: 3
            Console.WriteLine("Popped element: " + stack.Pop()); // Output: 3
            Console.WriteLine("Popped element: " + stack.Pop()); // Output: 2
            Console.WriteLine("Is stack empty? " + stack.IsEmpty()); // Output: False
            Console.WriteLine();

            // LinkedList methods execution
            Console.WriteLine("LinkedList methods execution:");
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddElement(1);
            linkedList.AddElement(2);
            linkedList.AddElement(3);
            Console.WriteLine("Index of 2: " + linkedList.IndexOfanElement(2)); // Output: 1
            Console.WriteLine("Does it contain 4? " + linkedList.CheckElement(4)); // Output: False
            linkedList.RemoveElement(2);
            Console.WriteLine("Index of 2 after removal: " + linkedList.IndexOfanElement(2)); // Output: -1
            Console.WriteLine("Is linked list empty? " + linkedList.IsEmpty()); // Output: False

            Console.ReadLine();
        }


    }
}
