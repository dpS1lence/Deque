using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using StaticDeque.Deque;

namespace StaticDeque
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("int Deque with the file values :");
            Deque<int> dequeInt = new Deque<int>();
            dequeInt.InsertRear(5);
            dequeInt.InsertRear(8);
            dequeInt.InsertRear(1);
            dequeInt.InsertRear(9);
            Console.WriteLine(dequeInt.DeleteFront());
            Console.WriteLine(dequeInt.DeleteFront());
            dequeInt.InsertRear(7);
            dequeInt.InsertRear(4);
            dequeInt.InsertRear(6);
            Console.WriteLine(dequeInt.DeleteRear());
            dequeInt.InsertFront(2);
            Console.WriteLine(string.Join(" ", dequeInt.ToArray()));
            Console.WriteLine();
            Console.WriteLine("string Deque :");
            Deque<string> dequeString = new Deque<string>();
            dequeString.InsertRear("atanas");
            dequeString.InsertFront("mitko");
            dequeString.InsertFront("sashko");
            dequeString.InsertFront("nasko");
            dequeString.InsertRear("georgi");
            Console.WriteLine(dequeString.DeleteFront());
            Console.WriteLine(string.Join(" ", dequeString.ToArray()));
        }
    }
}