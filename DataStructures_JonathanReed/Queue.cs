using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_JonathanReed
{
    public class Queue<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Enqueue(T data)
        {
            list.AddLast(data);
        }
        public T Dequeue()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T value = list.First;
            list.RemoveFirst();
            return value;
        }
        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return list.First;
        }

        public int Count => list.Count;

        public void PrintAll()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
