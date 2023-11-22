using System;
using System.Runtime.CompilerServices;



namespace MakingMethods
{
    internal class Program
    {


      private static void Main(string[] args)
         {
            // get user name
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            //get age 
            Console.WriteLine("How old are you? (number only)");
            int Age= int.Parse(Console.ReadLine());
            // get cat or dog
            Console.WriteLine("Do you have a cat or a dog?");
            string animal= Console.ReadLine();
            //get the name
            Console.WriteLine("What is the name of your pet?");
            string animalName = Console.ReadLine();
            //gets a color
            Console.WriteLine("Name a color?");
            string color = Console.ReadLine();
            //gets first number
            Console.WriteLine("Enter in a number");
            int num1 = int.Parse(Console.ReadLine());
            //get second number
            Console.WriteLine("Enter a second number");
            int num2 = int.Parse(Console.ReadLine());
            //get third number
            Console.WriteLine("Enter a third number");
            int num3 = int.Parse(Console.ReadLine());


            Console.WriteLine("Hello! " + userName + " you're " + Age + " years old. You have a " + animal + " it's name is " + animalName + ". The color that you chosen " + color);
            int Add = sum(num1, num2, num3);
            Console.WriteLine($" this is the sum of the number: {Add}");
            int multiple = multi(num1, num2, num3);
            Console.WriteLine($"This is the multiple: {multiple}");
         }
        // this will add all the number up
        public static int sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        
        public static int multi(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }


    }
      
}