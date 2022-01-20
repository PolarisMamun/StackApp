using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = new int[] { 1, 2, 3, 4};
            Stack<string> myStack = new Stack<string>();
            myStack.Push("A");
            myStack.Push("B");
            myStack.Push("C");
            myStack.Push("D");

            
           // Console.WriteLine();


            foreach (var item in myStack)
            {
                Console.WriteLine(item + ",");
            }

            string popName = myStack.Pop();

            Console.WriteLine("------------------");
            Console.WriteLine(popName);

            //myStack.Pop();

            Console.WriteLine("------------------");
            string name = myStack.Peek();
            Console.WriteLine(name);
            Console.WriteLine("------------------");

            foreach (var item in myStack)
            {
                Console.WriteLine(item + ",");
            }

            Console.ReadLine();
        }
    }
}
