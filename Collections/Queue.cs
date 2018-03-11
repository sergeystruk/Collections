using System;

namespace CollectionUtil
{
    public class Queue<T>
    {
        #region Fields

        private T[] array;
        private int head;
        private int tail;

        #endregion

        #region Constructions

        public Queue() : this(0) { }

        public Queue(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }
            array = new T[capacity];
            head = 0;
            tail = 0;
        }

        #endregion

        #region API

        public bool Empty()
        {
            return head == tail;
        }

        public int Size()
        {
            if (head > tail)
            {
                return array.Length - head + tail;
            }
            else
            {
                return tail - head;
            }
        }

        public void Enqueue(T newElem)
        {
            if (Size() != array.Length)
            {
                array[tail] = newElem;
                tail = ++tail;
            }
            else
            {
                Resize();
                array[tail] = newElem;
                tail = ++tail;
            }
        }

        public T Dequeue()
        {
            if (Empty())
            {
                return default(T);
            }
            else
            {
                T value = array[head];
                head = ++head;
                return value;
            }
        }

        #endregion

        #region Helpers

        private void Resize()
        {
            if (array.Length == 0)
            {
                T[] newStaticArray = new T[100];
                array = newStaticArray;
            }
            else
            {
                T[] newArray = new T[2 * array.Length];
                Array.Copy(array, 0, newArray, 0, tail);
                array = newArray;
            }
        }

        public override string ToString()
        {
            string str = string.Empty;
            if (head < tail)
            {
                for (int i = head; i < tail; i++)
                {
                    str += array[i].ToString() + "\t";
                }
            }
            return str;
        }
        #endregion
    }
}