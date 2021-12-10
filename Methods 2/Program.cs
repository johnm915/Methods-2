using System;

namespace Methods_2
{
    class Program
    {
        static void Main(string[] args)
        {        

           Console.WriteLine("What is your name?");

           string userName = Console.ReadLine();
            
           // Console.WriteLine($"Hi {userName} What is your Favorite color");

            
           //string favoriteColor = Console.ReadLine();

           // Console.WriteLine("What is your favorite animal?");
            
           // string favAnimal = Console.ReadLine();

           // Console.WriteLine("What is your favorite band?");

           // string favBand = Console.ReadLine();

           // Console.WriteLine($"Hey {userName}, your favorite color is {favoriteColor}." + $" Your pet is a {favAnimal}. Your favorite band is {favBand}.  ");

            Console.WriteLine($"{userName} Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{userName} Give me a number to add to the first number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Add(num1, num2);
            Console.WriteLine($"The sum is: {sum}");


            Console.WriteLine($"{userName} Give me a number to multiply");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Then give me a number to multiply that number");
            int y = int.Parse(Console.ReadLine());

            int product = Product(x, y);
            Console.WriteLine($"the product is: {product}");
            
        }

            public static int Add(int num1, int num2)
           
        {
          
            return num1 + num2; 
        } 
       public static int Product(int x, int y) 
        {
            
            return x * y; 




        }
        
    }
}
