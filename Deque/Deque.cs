using StaticDeque.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDeque.Deque
{
    public class Deque<T> : IDeque<T>
    {
        private int firstDequeElqment = 0;
        private int lastDequeElqment = -1;
        private T[] dequeArray;
        public Deque()
        => dequeArray = new T[4];
        public Deque(int arrayLength)
        => dequeArray = new T[arrayLength];
        private int DequeArrayCount
        {
            get { return dequeArray.Length; }
        }
        private int DequeCount { get; set; }  
        public void InsertFront(T element)
        {
            if (DequeCount >= DequeArrayCount)
            {
                Resize();
            }
            if (dequeArray[lastDequeElqment] == null || dequeArray[firstDequeElqment].Equals(default(T)))
            {
                lastDequeElqment++;
                dequeArray[firstDequeElqment] = element;
            }
            else if(DequeCount < DequeArrayCount)
            {
                if (firstDequeElqment <= 0)
                {
                    firstDequeElqment = DequeArrayCount - 1;
                }
                else firstDequeElqment--;
                dequeArray[firstDequeElqment] = element;
            }
            DequeCount++;
        }

        public void InsertRear(T element)
        {
            if (DequeCount >= DequeArrayCount)
            {
                Resize();
            }
            if(lastDequeElqment + 1 < DequeArrayCount)
            {
                lastDequeElqment++;
            }
            else
            {
                lastDequeElqment = 0;
            }
            if (dequeArray[lastDequeElqment] == null || dequeArray[lastDequeElqment].Equals(default(T)))
            {
                dequeArray[lastDequeElqment] = element;
            }
            DequeCount++;
        }
        public T DeleteFront()
        {
            if (DequeCount == 0) throw new InvalidOperationException("The deque is empty");
            T value = dequeArray[firstDequeElqment];
            dequeArray[firstDequeElqment] = default(T);
            if(firstDequeElqment + 1 > DequeArrayCount)
            {
                firstDequeElqment = 0;
            }
            firstDequeElqment++;
            DequeCount--;
            return value;
        }

        public T DeleteRear()
        {
            if (DequeCount == 0) throw new InvalidOperationException("The deque is empty");
            T value = dequeArray[lastDequeElqment];
            dequeArray[lastDequeElqment] = default(T);
            if (lastDequeElqment - 1 < 0)
            {
                lastDequeElqment = DequeArrayCount - 1;
            }
            lastDequeElqment--;
            DequeCount--;
            return value;
        }
        public T[] ToArray()
        {
            T[] newArray = new T[DequeArrayCount * 2];
            int newArrayCounter = 0;
            for (int i = firstDequeElqment; i < DequeArrayCount; i++)
            {
                newArray[newArrayCounter] = dequeArray[i];
                newArrayCounter++;
            }
            if (newArrayCounter < DequeCount)
            {
                for (int i = 0; i <= lastDequeElqment; i++)
                {
                    newArray[newArrayCounter] = dequeArray[i];
                    newArrayCounter++;
                }
            }
            T[] valueArr = new T[DequeCount];
            for (int i = 0; i < DequeCount; i++)
            {
                valueArr[i] = newArray[i];
            }
            return valueArr;
        }
        private void Resize()
        {
            T[] newArray = new T[DequeArrayCount * 2];
            int newArrayCounter = 0;
            for (int i = firstDequeElqment; i < DequeCount; i++)
            {
                newArray[newArrayCounter] = dequeArray[i];
                newArrayCounter++;
            }
            if(newArrayCounter < DequeCount)
            {
                for (int i = 0; i <= lastDequeElqment; i++)
                {
                    newArray[newArrayCounter] = dequeArray[i];
                    newArrayCounter++;
                }
            }
            dequeArray = newArray;
            firstDequeElqment = 0;
            lastDequeElqment = DequeCount - 1;
        }
    }
}
