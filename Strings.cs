using System;
using System.Collections.Generic;


namespace CsharpBasics
{
    public class Strings
    {
        static void Main(string[] args)
        {
            // Conditionals.Main1();
            // Console.WriteLine("These are String Exercises");
            // Consecutive();
            // Duplicates();
            // TimeValid();
            // PascalCase();
            CountVowels();

        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>

        public static void Consecutive()
        {
        System.Console.WriteLine("Enter numbers separated by hyphen");
        var input = Console.ReadLine();
        var numbers= new List<int>();
        foreach(var number in input.Split('-'))
            numbers.Add(Convert.ToInt32(number));
        var isConsecutive=true;
        numbers.Sort();

        for (var i=1; i<numbers.Count;i++)
        {
            if (numbers[i]!=numbers[i-1]+1)
            {
                isConsecutive=false;
                break;
            }

        }
        var message = isConsecutive? "Consecutive" : "Not Consecutive";
        System.Console.WriteLine(message);           
        } 


        public static void Duplicates()
        {
         System.Console.WriteLine("enter numbers separated by hyphens");
         var input=Console.ReadLine();
         if (String.IsNullOrEmpty(input)) return;
         var numbers=new List<int>();
        ;
         foreach(var num in input.Split("-"))
                numbers.Add(Convert.ToInt32(num));
        
        var uniques=new List<int>();
        var duplicates=false;
        foreach(var e in numbers)
        {
            if (!uniques.Contains(e)) uniques.Add(e);
            else
            {
                duplicates = true;
                break;
            } 

                
        }
        if (duplicates) 
        System.Console.WriteLine("duplicates");
        else
        System.Console.WriteLine("no duplicates");


        }

        public static void TimeValid()
        {
            System.Console.WriteLine("Enter time:");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input)) 
            {
                System.Console.WriteLine("Invalid Time");
                return;
            }
            var components=input.Split(":");
           
            try {
                var hour = Convert.ToInt32(components[0]);
                var min = Convert.ToInt32(components[1]);
                if(hour>=0 && hour<=23 && min>=0 && min<=59)
                System.Console.WriteLine("Valid Time");
                else System.Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Invalid Time");
            }

        }
        public static void PascalCase() 
        {
            System.Console.WriteLine("Enter a few words");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input)) 
            {
                System.Console.WriteLine("Error");
                return;
            }
         
                var words=input.Split(" ");
                var variableName ="";
                foreach(var word in words)
                {
                var wordInPascal= char.ToUpper(word[0])+ word.ToLower().Substring(1);
                variableName+=wordInPascal;

                }
                System.Console.WriteLine(variableName);            
        }

        public static void CountVowels()
        {
            System.Console.WriteLine("Enter a word");
            var input = Console.ReadLine().ToLower();
            var count=0;
            var vowelList= new List<char>(new char[] {'a','e','i','o','u'});
            foreach(var letter in input){
                if(vowelList.Contains(letter)){
                    count++;
                }
            }
            System.Console.WriteLine("{0} contains {1} vowels", input,count);
        }

    }




}