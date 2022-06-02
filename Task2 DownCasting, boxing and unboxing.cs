using System;

namespace _220602_classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car = (Car) vehicle;
            int a = 5;
            object obj = a;
            int b = (int)obj;

        }
            
        public class Vehicle
        {

        }
            
        sealed class Car : Vehicle
        {
           
        }
       
    }
}
