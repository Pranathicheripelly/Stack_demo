using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_demo
{
    

       
        class Program
        {
            static void Main(string[] args)
            {
                runApp();
            }

            static void runApp()
            {
                stack stack = new stack();

                // Push elements onto the stack
                stack.Push(20);
                stack.Push(30);
                stack.Push(40);

                // Pop elements from the stack and display them
                Console.WriteLine("Stack Elements:");
                int element;
                while (stack.Pop(out element))
                {
                    Console.WriteLine(element);

                }
                Console.ReadLine();
            }
        }

    }

