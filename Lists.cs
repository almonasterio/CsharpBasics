using System;
using System.Collections.Generic;

namespace CsharpBasics {

    public class Lists
    {
        static void Main(string[] args)
        {
            // Likes();
            // Reversed();
            // SortFive();
            // DisplayUnique();
            Smallest();

        }

        public static void Likes()
        {
            var names = new List<string>();
            while (true){
            System.Console.WriteLine("Type a name or hit ENTER to QUIT");
            var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input)) break;
                names.Add(input);
            }
            if (names.Count>2) 
                System.Console.WriteLine("{0}, {1} and {2} more people like your post", names[0],names[1],names.Count-2);
            else if (names.Count == 2) 
                System.Console.WriteLine("{0}, {1} more people like your post", names[0], names[1]);
            else if (names.Count == 1) 
                System.Console.WriteLine("{0} likes your post", names[0]);
            else 
                Console.WriteLine();
          


        }
        public static void Reversed(){
                System.Console.WriteLine("Enter a name");
                var name = Console.ReadLine();
                var array =new char[name.Length];

            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

        
            var reversed = new string(array);
            System.Console.WriteLine("Reversed name: " + reversed);

        }
        public static void SortFive()
        {
            var arr= new List<int>();
            while (arr.Count<5) {
                System.Console.WriteLine("Enter a number");
                var input= Convert.ToInt32(Console.ReadLine());

       
                if (arr.Contains(input)) {
                        System.Console.WriteLine("Number already entered try again");
                        continue;
                }
                arr.Add(input);

            }
            arr.Sort();
            System.Console.WriteLine("Sorted numbers: ");
            foreach(var num in arr){
                System.Console.WriteLine(num);
            }
        }

        public static void DisplayUnique()
        {
            var numbers = new List<int>();
            while(true) {
    
                System.Console.WriteLine("Enter number or \"Quit\" to exit");
                var input =Console.ReadLine();

                if (input.ToLower()=="quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
           
            }

            var unique= new List<int>();
            foreach(var num in numbers){
                if (!unique.Contains(num)){

                    unique.Add(num);
                    System.Console.WriteLine(num);


                }
            }
       
        }

        public static void Smallest()
        {
            string[] elements;
            while (true){
                System.Console.WriteLine("Enter a list of numbers separated by comas , ");
                var input =Console.ReadLine();
                elements=input.Split(",");
        
                if (!String.IsNullOrWhiteSpace(input)){
                    if (elements.Length>=5)
                        break; 
                }
                System.Console.WriteLine("Invalid List");
            }
            var listNumbers = new List<int>();

            foreach (var num in elements)
            {
                listNumbers.Add(Convert.ToInt32(num));
            }
            var smallest=new List<int>();


            while(smallest.Count<3){
                var min=listNumbers[0];
            foreach(var number in listNumbers){
                    if (number<min)
                    min=number;

            }
            smallest.Add(min);
            listNumbers.Remove(min);
             
            }
            foreach (var smallnum in smallest)
            System.Console.WriteLine(smallnum);
        }

    }

}