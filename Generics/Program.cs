using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {

        
        //public List<int> listOfInts = new List<int>();
        //public LinkedList<string> linkedListOfStrings = new LinkedList<string>(words);
        //public Queue<int> queueOfInts = new Queue<int>();
        //public Stack<int> stackOfInts = new Stack<int>();
        //public Dictionary<int, int> dict = new Dictionary<int, int>();
        //public SortedList<int, int> sortedList = new SortedList<int, int>();
        //public HashSet<int> hashTable = new HashSet<int>();


   
        static void Main(string[] args)
        {
            List<int> listOfInts = new List<int>();
            listOfInts.Add(1);
            listOfInts.Add(2);
            listOfInts.Add(3);
            listOfInts.Add(4);
            listOfInts.Add(5);
            Console.WriteLine("Five ints from a normal list");
            foreach (var integer in listOfInts)
            {
                Console.WriteLine($"{integer}");
            }
            Console.WriteLine("");

            string[] words = new string[] {"The", "Dog", "Jumped", "Very", "Far"};
            LinkedList<string> linkedListOfStrings = new LinkedList<string>(words);
            Console.WriteLine("Five Strings from LinkedList");
            foreach (var item in linkedListOfStrings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            Queue<int> queueOfInts = new Queue<int>();
            queueOfInts.Enqueue(6);
            queueOfInts.Enqueue(7);
            queueOfInts.Enqueue(8);
            queueOfInts.Enqueue(9);
            queueOfInts.Enqueue(10);
            Console.WriteLine("Five ints from Queue");
            foreach (var item in queueOfInts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            Stack<int> stackOfInts = new Stack<int>();
            stackOfInts.Push(11);
            stackOfInts.Push(12);
            stackOfInts.Push(13);
            stackOfInts.Push(14);
            stackOfInts.Push(15);
            Console.WriteLine("Five ints from a Stack");
            foreach (var item in stackOfInts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(4, 40);
            dict.Add(2, 20);
            dict.Add(5, 50);
            dict.Add(3, 30);
            dict.Add(1, 10);
            Console.WriteLine("Five Values from a dictionary");
            foreach (KeyValuePair<int, int> Ints in dict)
            {
                Console.WriteLine(Ints);
            }
            Console.WriteLine("");

            Console.WriteLine();
            SortedList<int, int> sortedList = new SortedList<int, int>();
            sortedList.Add(5, 50);
            sortedList.Add(2, 20);
            sortedList.Add(1,10);
            sortedList.Add(4, 40);
            sortedList.Add(3, 30);
            Console.WriteLine("Five pair of ints from SortedList");
            foreach (KeyValuePair<int, int> Ints in sortedList)
            {
                Console.WriteLine(Ints);
            }
            Console.WriteLine("");

            HashSet<int> hashTable = new HashSet<int>();
            hashTable.Add(15);
            hashTable.Add(15);
            hashTable.Add(16);
            hashTable.Add(17);
            hashTable.Add(18);
            hashTable.Add(19);
            Console.WriteLine("Five Ints from HashSet");
            foreach (var item in hashTable)
            {
                Console.WriteLine(item);
            }
        }
    }
}
    
        

    

