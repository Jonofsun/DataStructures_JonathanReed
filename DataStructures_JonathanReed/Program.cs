using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_JonathanReed
{
    internal class Program
    {
        /* Jonathan Reed
         * 2/12/2024
         *
         */
        static void Main(string[] args)
        {
            var singlyLinkedList = new LinkedList<int>(); // Currently Testing
            var doublyLinkedList = new DoublyLinkedList<int>(); // Not functional
            var queue = new Queue<int>();
            var stack = new Stack<int>();

            string dataStructure = "SinglyLinkedList"; // Change this to test other structures

            switch (dataStructure)
            {
                case "SinglyLinkedList":
                    singlyLinkedList.AddFirst(1);
                    singlyLinkedList.AddLast(2);
                    singlyLinkedList.PrintAll();
                    break;
                case "DoublyLinkedList":
                    doublyLinkedList.AddFirst(1);
                    doublyLinkedList.AddLast(2);
                    doublyLinkedList.PrintAll();
                    break;
                case "Queue":
                    queue.Enqueue(1);
                    queue.Enqueue(2);
                    queue.PrintAll();
                    break;
                case "Stack":
                    stack.Push(1);
                    stack.Push(2);
                    stack.PrintAll();
                    break;
                default:
                    Console.WriteLine("Invalid data structure");
                    break;
            }

        }
    }
}
