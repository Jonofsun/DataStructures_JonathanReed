using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_JonathanReed
{
    public class Stack<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Push(T data)
        {
            list.AddFirst(data);
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T value = list.First;
            list.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
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
