// C# program to calculate the area of a square using the concept of abstraction

using System;

namespace AbstractionAssignment
{
    

        // abstract class
        abstract class Shape
        {
            // abstract method
            public abstract string Area(int side);
        }
        //square class inheriting the shape class

        class Square : Shape
        {
        public override string Area(int side)
        {
            
            this.Sides = side;
            
            return "The area of the square is"+side * side;
        }
        //private member
        public int Sides { get; private set; }



            // method of square class

            public Square(int x)
            {
             int side = x;
             
            }

        
        }
        // Driver Classs
        class KFD
        {

            // Main Method

            public class Program
            {
                static void Main(string[] args)
                {
                    // creating reference of Shape class which rfer to Square class instance

                    Shape sh = new Square(15);
                    // calling method

                    string result = sh.Area(15);

                    Console.WriteLine("{0}", result);
                }
            }

        }
    

}