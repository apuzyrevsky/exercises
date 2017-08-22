using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class GenericList<T>
    {
        private T[] testList;
        private int usedIndex;


        public GenericList(int capacity)
        {
            testList = new T[capacity];
            usedIndex = 0;
        }
        public void AddItem(T item)
        {
            if (usedIndex >= testList.Length)
            {
                throw new InvalidOperationException("Array is full.");
            }
            testList[usedIndex] = item;
            usedIndex++;
        }
        public T RemoveItem(int index)
        {
            if (index < 0 || index >= usedIndex)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid cell index: " + index);
            }
            T removedItem = testList[index];
            for (int i = index; i < usedIndex -1; i++)
            {
                testList[i] = testList[i + 1];
            }
            testList[usedIndex - 1] = default(T);
            usedIndex--;
            return removedItem;
        }
        public T FindItem(int index)
        {
            T selectedItem = testList[index];
            return selectedItem;
        }
        public void InsertItem(int index, T item)
        {
            if (index < 0 || index <= usedIndex)
            {
                throw new ArgumentOutOfRangeException(
                    "That index is already used" + index);
            }
            testList[index] = item;
            usedIndex++;
        }
        public void ShowItems()
        {
            foreach (var item in testList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
