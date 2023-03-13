using System;

namespace midterm {
    class Program {
        static void Main(string[] args){
            
            Console.Write("input x1 : ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("input y1 : ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("input w1 : ");
            double w1 = double.Parse(Console.ReadLine());
            Console.Write("input h1 : ");
            double h1 = double.Parse(Console.ReadLine());

            Console.Write("input x2 : ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("input y2 : ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("input w2 : ");
            double w2 = double.Parse(Console.ReadLine());
            Console.Write("input h2 : ");
            double h2 = double.Parse(Console.ReadLine());
            
            double a1 = w1 * h1 * 4;
            double a2 = w2 * h2 * 4;
            
            if (a1 - a2 > 8 ) {
                Console.WriteLine("Too Much Overlaping");
            } else if (a1 - a2 < 8 ) {
                Console.WriteLine("Not Much Overlapping");
            } else {
                Console.WriteLine("No Overlapping");
            }
        }
    }
}    