using System;

namespace exceptionhandling
{
    class Program
    {   
        public static DateTime date { get; set; }
        static void Main(string[] args)
        {
            
//room number
            Console.WriteLine("Enter Room Number: ");
            
            string roomNumber = null;
            try{
                roomNumber = Console.ReadLine();

            }
            catch (Exception) {
                Console.WriteLine($"Nothing was entered"); 
            }
           
//name
            Console.WriteLine("Name: ");
            string studentName = Console.ReadLine();
//date entered
            bool dateSuccess = false;
                while(dateSuccess != true)
                    try
                    {
                        Console.WriteLine("Enter Date Entered: ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        dateSuccess = true;

                    }
                        catch (FormatException m)
                    {
                        Console.WriteLine("Incorrect date type entered. " + m.Message);
                    }   
//time entered
                Console.WriteLine("Enter Time Entered: ");
                DateTime time = DateTime.Parse(Console.ReadLine());
//amount stayed
                Console.WriteLine("Amount of time person stayed in min: ");
                int duration = int.Parse(Console.ReadLine());

           
        }
    }
}
