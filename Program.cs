using System;

namespace CsharpBasics
{
    public class Conditionals
    {
        public static void Main1()
        {
            // Loop1();
            // Factorial();
            // PrevSum();
            // Guess();
            // MaxNum();
            // ValidNumber();
            // CompareNumbers();
        }

        public static void ValidNumber(){
            Console.WriteLine("Introduce a number between 1 and 10");            
            var input = Console.ReadLine();
            var number =Convert.ToInt32(input);
            if (number<=10 && number>=0)  
            Console.WriteLine("Valid");
            else Console.WriteLine("Invalid");
            Console.WriteLine();
        }

        public static void CompareNumbers(){
            Console.WriteLine("Enter two numbers");
            var num1= Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2) 
              Console.WriteLine("{0} is bigger",num1);
            else if (num2>num1)
                Console.WriteLine("{0} is bigger", num2);
            else Console.WriteLine("{0} is equal to {1}", num1,num2);   
            Console.WriteLine(); 
        }

        
      public static void Loop1()
      {
          int count = 0;
          for (var i=1;i<=100;i++)
          {
              if (i%3==0) {
              Console.WriteLine(i);
              count++;
              }
          }
          Console.WriteLine("{0} numbers are divisible by 3 between 0 and 100.", count);
      }

    public static void Factorial()
    {
        Console.WriteLine("Enter a number");
        int input = Convert.ToInt32(Console.ReadLine());
        var i=1;
        var factorial=1;
        while (i<input){
            factorial*=i;
            i++;
        }
        Console.WriteLine("The factorial of {1} is {0}",factorial,input);
    }

    public static void PrevSum()
    {
       
        var sum = 0;
        while (true)
        {
            System.Console.WriteLine("Enter a number (or 'ok' to exit): ");
           var input = Console.ReadLine(); 
            if (input.ToLower()=="ok") break;
            sum+=Convert.ToInt32(input);


        }
        System.Console.WriteLine("The total sum of previous numbers is {0}",sum);
    }

    public static void Guess(){
        var i=4;
        int randomNum=new Random().Next(1,10);
        while(i>0)
        {
            System.Console.WriteLine("Guess a number you have {0} more chances.",i);
            if (randomNum==Convert.ToInt32(Console.ReadLine())){
            System.Console.WriteLine("You won! The number was {0}", randomNum);
            break;
            }
            i--;

        }
        if (i==0) System.Console.WriteLine("You lost! Number was {0}", randomNum);
    }

    public static void MaxNum()
    {
        System.Console.WriteLine("Enter numbers separated by comas");
        var input = Console.ReadLine();
        var array=input.Split(",");
        var max =Convert.ToInt32(array[0]);
   
        foreach (var e in array) {
                if (Convert.ToInt32(e)>max) max=Convert.ToInt32(e);            
        }

            Console.WriteLine(max);
    }
    }
}


