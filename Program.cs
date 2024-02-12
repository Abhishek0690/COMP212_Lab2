using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _301271921_Abhishek__Lab3
{
    internal class Program
    {
        public LinkedList<int> reverseList(LinkedList<int> list)
        {
            LinkedList<int> newList = new LinkedList<int>();
            foreach (var i in list)
            {
                newList.AddFirst(i);
            }
            return newList;
        }
        static void Main(string[] args)
        { 
            LinkedList<int> list = new LinkedList<int>();
            //Entering 10 random integers to the list
            Random random = new Random();
            list.AddFirst(random.Next(100));
            for(int i = 0; i <= 10; i++)
            {
                int j = random.Next(100);
                list.AddAfter(list.First, j);
            }
            //Printing the List in Normal Order
            foreach(int j in list)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Reversing the List");
            var reversedList = list.Reverse();
            foreach (int j in reversedList)
            {
                Console.WriteLine(j);
            }
        }
    }
}
