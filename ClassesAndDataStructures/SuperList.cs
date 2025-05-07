using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndDataStructures
{
    internal class SuperList<T>
    {
        private T[] _realArray;

        public SuperList()
        {
            _realArray = [];
        }

        public void Push(T item)
        {
            var originialLenght = _realArray.Length;
            var newArray = new T[originialLenght + 1];
            for (int i = 0; i < originialLenght; i++)
            {
                newArray[i] = _realArray[i];
            }
            newArray[originialLenght] = item;

            _realArray = newArray;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _realArray.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return _realArray[index];
        }

        public T Pop()
        {
            int originialLenght = _realArray.Length;
            int newArrayLength = originialLenght - 1;
            var newArray = new T[newArrayLength];
            T element = _realArray[originialLenght - 1];

            for (int i = 0; i < newArrayLength; i++)
            {
                newArray[i] = _realArray[i];
            }
            _realArray = newArray;
            return element;
        }

        public void Delete(int index)
        {
            int newArrayLength = _realArray.Length - 1;
            var newArray = new T[newArrayLength];

            for (int i = 0;i < newArrayLength;i++)
            {
                if (i == index) continue;
                newArray[i] = _realArray[i];
            }
        }

        public void Unshift(T[] newItems)
        {
            var newArray = new T[_realArray.Length + newItems.Length];

            foreach (var item in newItems) newArray.Append(item);
           
            foreach (var item in _realArray) newArray.Append(item);

            _realArray = newArray;
        }

        public T Shift()
        {
            var newArray = new T[_realArray.Length - 1];

            T element = _realArray[0];

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i - 1] = _realArray[i];
            }

            _realArray = newArray;
            return element;
        }
    }
}
