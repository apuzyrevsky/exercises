using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            GenericList<int> numbers = new GenericList<int>(length);
            numbers.AddItem(1488);
            numbers.AddItem(43);
            numbers.AddItem(25);
            numbers.ShowItems();
            int ss = numbers.FindItem(2);
            numbers.InsertItem(4, 666);
            numbers.RemoveItem(2);
            numbers.ShowItems();





        }
    }
}
