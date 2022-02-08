using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_02
{
    internal class Program
    {
        static int charges(int weight,int distance)
        {
            int cost=0;
            if (distance < 100)
            {
                cost=50*weight;
            }
            else if(distance >=100 && distance < 200)
            {
                cost = 115 * weight;
            }
            else if(distance>=200 && distance < 300)
            {
                cost = 205 * weight;
            }
            else
            {
                cost = 325 * weight;
            }
            return cost;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the weight and distance");
            int weight = Convert.ToInt32(Console.ReadLine());
            int distance = Convert.ToInt32(Console.ReadLine());
            int cost = charges(weight, distance);
            Console.WriteLine($"For entered weight {weight} and distance {distance} the cost is {cost}");
            Console.ReadLine();
        }
    }
}
