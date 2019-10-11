using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1. Multiplication Table
            /*int userNumber;
            Console.WriteLine("Please enter a number");

            userNumber = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= 10; i++) 
            {
                Console.WriteLine($"{userNumber} x {i} = {userNumber * i}");


            }*/




            // Find Length of Word

            /*string name;
            Console.WriteLine("Enter you name");
            name = Console.ReadLine();

            int counter = 0;
            foreach (char letter in name)
            {
                counter++;

            }
            Console.WriteLine($"Your name is {counter} letters long");*/









            /*string name;
            bool letterFound = false;
            foreach (char letter in name) ;

            {
                if (letter == 'a')
                {
                    letterFound = true;
                    break;
                   
                }             

            }
            if (letterFound)
            {
                Console.WriteLine("Letter A found");

            }
            else
            {
                Cosole.WriteLine("Letter a is not in your name");

            }*/


            /*int aTotal = 0;
            string name;
            Console.WriteLine("Enter you name");
            name = Console.ReadLine();

            for(int = 0; i < name.Length; i++)
            {
                if(name[i] == 'a')
                {
                    aTotal++;

                }
            }
            Console.WriteLine($" There are {aTotal} \"A\" letters in your name ");







            Console.ReadLine();*/


            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            /*foreach(char letter in name)
            {
                Console.Write($"{letter} ");

            }*/

            /*for(int i = 0; i< name.Length; i++)
            {
                if(i == name.Length-1)
                {
                    Console.Write($"{name[i]}");

                    break;
                }

                // KODUS WHILE loop üleval olevast 




                Console.Write($"{ name[i]} * ");

            }*/

            /*int i = 1;

            while( i <= 10)
            {
                Console.WriteLine(i);
                i++;

            }*/



            string hello = "hello";
            int i = 0;
            while (i < hello.Length)
            {
                Console.WriteLine($"{hello[i]}");
                i++;

            }


            Console.ReadLine();


        }
    }
}
