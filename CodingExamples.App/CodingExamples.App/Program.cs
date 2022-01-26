using System;
using CodingExamples.Data.Mgr;

namespace CodingExamples.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("1: String Calculator.");
            Console.WriteLine("2: Linked List.");
            Console.WriteLine("Please type your selection (1 or 2): ");
            var entry = Int32.Parse(Console.ReadLine());
            if (entry == 1)
            {
                StringCalcMgr calcMgr = new StringCalcMgr();
                Console.WriteLine("Enter a string you wish to add: ");
                var result = calcMgr.Add(Console.ReadLine());
                Console.WriteLine($"The result is: {result}");
            }
            else if (entry == 2)
            {
                Console.WriteLine("Add First:");
                LinkedListMgr myList1 = new LinkedListMgr();

                myList1.AddFirst("Hello");
                myList1.AddFirst("Magical");
                myList1.AddFirst("World");
                myList1.printList();

                Console.WriteLine();

                Console.WriteLine("Add Last:");
                LinkedListMgr myList2 = new LinkedListMgr();

                myList2.AddLast("Hello");
                myList2.AddLast("Magical");
                myList2.AddLast("World");
                myList2.printList();

            }
            else
                Console.WriteLine("Invalid Selection!");
        }
    }  
}
