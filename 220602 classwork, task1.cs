using System;

namespace _220602_classwork
{
    class Program
    {
        static void Main(string[] args)
        {    
            string Response;
            long[] arr = new long[0];

            do
            {
                Console.WriteLine("Please enter a number");
                string ededStr = Console.ReadLine();              
                long number = long.Parse(ededStr);
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = number;

                Console.WriteLine("Would you like add a number, enter 'y' if yes and 'n' if no");
                Response = Console.ReadLine();

            } while (Response == "y");

            foreach(var longItem in arr)
            {
                checked
                {
                    try
                    {
                        int a = (int)longItem;
                    }
                    catch
                    {
                        count++;
                    }
                }
                int a = (int)longItem;
            }
            
        }
    }
}
