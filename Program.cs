using System;

/*
Author: Yessica Auguste
Date: 7/9/2023
Description: C# console application that uses two methods to populate and sum random numbers from an array
*/

namespace Deliverable__2_
{
    class Program
    {
        //To create new method named random array
        static int[] random_array(int array_len)
        {
         
                //To generate random numbers between 10 and 50 
                Random random = new Random();
                int[] RandArray = new int[array_len];
                for (int i = 0; i < array_len; i++)
                {
                    RandArray[i] = random.Next(10, 50);
                }
                return RandArray;
        }
        
        //To create method 2 named sum
        static int Arraysum(int[] array)
        {
     
                //To use foreach loop to sum numbers from array
                int sum = 0;
                foreach (int item in array)
                {
                    sum = sum + item;
                }
                return sum;
        }
        
        static void Main(string[] args)
        {
            //Try statement tries all lines of codes between brackets
            try
            {
                //To define variable input
                int input = 0;

                //To use a loop to validate whether the users entry is between 5 and 15
                while (true)
                {
                    //To ask user for integer between 5 and 15
                    Console.WriteLine("Please enter an integer between 5 and 15.");
                    input = int.Parse(Console.ReadLine());

                    //If input is less than five or greater than 15, loops until valid integer is inputted
                    if(input >=5 &&  input <= 15)
                    {
                        break;
                    }
                }
                
                //To call back method 1 (random array)
                int[] NumbersArray = random_array(input);

                //To tell user what the numbers generated from the random array are
                Console.WriteLine("The elements from the random array are as follows: ");
                //To use foreach loop to list randomly generate numbers in console
                foreach (int element in NumbersArray)
                {
                    Console.WriteLine(element + " ");
                }

                Console.WriteLine(" ");
                //To tell the user the sum of the randomy generated numbers from the array
                Console.WriteLine("The sum of the randomly generated numbers is: " + Arraysum(NumbersArray));
            }
            //To catch erreneous inputs and gives statement when error is found
            catch
            {
                Console.WriteLine("Please enter a valid integer input and try again.");
            } 
        }
    }
}