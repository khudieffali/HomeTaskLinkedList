using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskLinkedList
{
    internal class MyStack<T> : IEnumerable
    {
        private T[] _arr;
        public int Count { get; set; }
        public int Capacity { get; set; }

        public MyStack()
        {
            Capacity = 4;
            _arr = new T[Capacity];
        }
        public MyStack(int capacity)
        {
            Capacity = capacity;
            _arr = new T[Capacity];
        }
        public MyStack(ICollection<T> item)
        {
            Capacity = item.Count;
            _arr = new T[Capacity];
            foreach (T value in item)
            {
                Push(value);
            }
        }

        public void Push(T item)
        {
            if (Capacity == Count)
            {
                Capacity *= 2;
                Array.Resize(ref _arr, Capacity);
            }
            _arr[Count]= item;
            Count++;
        }

        public T Pop()
        {
            if (Count==0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            T popItem = _arr[Count-1];
            Count--;
            return popItem;
        }
      
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            return _arr[Count-1];
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = Count-1; i >=0; i--)
            {
                yield return _arr[i];
            }
        }
    }
}
