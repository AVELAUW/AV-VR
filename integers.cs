using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace integers
{

    public class Program{
        public static void Main(string [] args){
           
        Console.WriteLine("Hello, World!"); //prints hello world

        //integers stop on a 2 billion
        //Example of a comment in C# {" // " or " /* */ "}
        //remove the question marks and replace them with the correct values
        //remove the comments and to get the code to run
        //an int is a 32-bit integer
        //int a1 = 5;
        
        ///<summary>
        /*
        int ? = 3;
        int ? = 5;
        int ? = 3;
        int ? = ?/?;
        Console.WriteLine(?);
        */





        ///<Longs>
        //Example of a comment in C# {" // " or " /* */ "}
        //remove the question marks and replace them with the correct values
        //remove the comments and to get the code to run
        //A long is a 64-bit integer
        //long a1 = 5;

        /*
        //longs biggest
        long ? = 5;
        long ? = 237;
        long ? = a1/b1;
        Console.WriteLine(?);
        */




        ///<Doubles>
        //Example of a comment in C# {" // " or " /* */ "}
        //remove the question marks and replace them with the correct values
        //remove the comments and to get the code to run
        //A double is a 64-bit floating point
        //double a1 = 5;

        /*
        //doubles bigger than int
        double a2 = ?;
        double b2 = ?;
        double c2 = ?/?;
        Console.WriteLine(?);
        */



        
        ///<Shorts>
        //Example of a comment in C# {" // " or " /* */ "}
        //remove the question marks and replace them with the correct values
        //remove the comments and to get the code to run
        //A short is a 16-bit integer
        //short a1 = 5;
        /*

        //shorts stop at 30 thousand
        short ? = 343;
        short ? = 23;
        //short ? = a3/b3;
        //Console.WriteLine(c3);
        */





        ///<Decimals>
        //Example of a comment in C# {" // " or " /* */ "}
        //remove the question marks and replace them with the correct values
        //remove the comments and to get the code to run
        //a decimal is a 128-bit floating point
        //decimal a1 = 5;

        /*
        //decimals for more accuracy
        ? a4 = 434;
        ? b4 = 53423;
        ? c4 = ?/?;
        Console.WriteLine(?);
        */



        ///<floats>
        /*
        float a5 = 131;
        float a6 = 343;
        Console.WriteLine(a5/a6);
        */






        ///<Booleans>
        /*
        //conditional statements
        bool something = a5 + a6 > 500;

        if(something)
            Console.WriteLine("I guessed that right");
        else 
            Console.WriteLine("Yeah right");

        */






        ///<loops>
        //Example of a comment in C# {" // " or " /* */ "}
        //remove the question marks and replace them with the correct values
        //remove the comments and to get the code to run
        //An Array is a collection of elements
        //int [] s = {1, 2, 3, 4, 5}; is an Array

        /// <summary>
        /*
        int [] s = {1, 2, 3, 4, 5};
        //forloops
        for(int i = 0; i < s.Length; i++)
        {
            Console.WriteLine("This loop is running");
        }
        */




        ///<whileloops>
        /*

        //while loops
        while (?)
        {
            Console.WriteLine("Hey buddy");
        }
        */
        

        //Example of a comment in C# {" // " or " /* */ "}
        //remove the question marks and replace them with the correct values
        //remove the comments and to get the code to run
        // let's solve for fibonacci
        // when you remove the comments, the code should run
        // replace the value for num with a new number for the sequence

        

        ///<fibonacci game building>
        //Replace 7 with any number and run the program.
        /*int num = 7;
        Fibonacci(num);
        */ 
        }


        /// <summary>
/// Fibonacci sequence
/// </summary>
/// <param name="num"></param>
    public static void Fibonacci(int num) { //fibonacci sequence
                int sum = 0;
                int i = 0;
            if(num==0){
                Console.WriteLine(num);
            } else if (num<0) {
                Console.WriteLine("Please enter a positive number");
            } else {
                while(i<num) {
                i = i+1;
                sum = sum + i;
            }
            Console.WriteLine($"The fibonacci of {num} is {sum}");
            }
            
        }
    }
}