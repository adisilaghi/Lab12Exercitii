using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Exercitii
{
    internal class Queue<T>
    {
        private T[] items;
        private int capacity;
        private int head;
        private int tail;
        private int count;
        public Queue(int capacity)
        {
            this.capacity = capacity;
            items = new T[capacity];
            head = 0;
            tail = 0;
            count = 0;
        }
        public void Enqueue(T item)
        {
            if (IsFull())
            {
                throw new Exception("Queue is full");
            }

            items[tail] = item;
            tail = (tail + 1) % capacity;
            count++;
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }

            T item = items[head];
            head = (head + 1) % capacity;
            count--;
            return item;
        }
        public int Count()
        {
            return count;
        }
        private bool IsFull()
        {
            return count == capacity;
        }
        private bool IsEmpty()
        {
            return count == 0;
        }
    }
}
