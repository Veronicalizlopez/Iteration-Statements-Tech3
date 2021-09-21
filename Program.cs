using System;

namespace Iteration_Statements_Tech3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter kilometers value between 10 and 25:");
            
            
            
            
             
            try
            {
                string input = Console.ReadLine();
                float kilometers = float.Parse(input);
                Console.WriteLine("Your value is: " + "" + kilometers);

                if ( kilometers >= 10 && ( kilometers <= 25))
                {




                    Console.WriteLine("While loop");
                    Console.WriteLine("This loop will iterate by increments of: " + kilometers.ToString() + " until 200");
                    int i =0;

                    const double CONVERTER = .621371;
                    while ( i <= 200)

                    {
                        double miles = kilometers* CONVERTER;
                        Console.WriteLine("Kilometers: "+kilometers.ToString()+"  "+ " Miles: "+ miles.ToString());
                        i++;
                        kilometers = kilometers + i;
                        Console.WriteLine(i);

                    }
                    
                }
                else
                {
                    Console.WriteLine("Incorrect Value!");
                    Console.WriteLine("Please enter a value between 10 and 25");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a numeric value ");
                Console.WriteLine(" Press any key to exit the program...");
                
            }
        }
    }
}
