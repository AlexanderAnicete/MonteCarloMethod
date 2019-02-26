using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonteCarloMethod
{
    class Program
    {
        

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a number to iterate through an array");
                int user = int.Parse(Console.ReadLine());
                MainMethod(user);
                
                continue;

            }
            
            
        }

        public static void MainMethod(int input)
        {
            
                Random random = new Random();
                int[] arr = new int[input];
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    Coordinates1 temp = new Coordinates1(random);
                    if (Triangle(temp) <= 1)
                    {
                        count += i;
                    }
                }
                double valueOfmonte = ((count / arr.Length) * 4 );
                Console.WriteLine(valueOfmonte);
                Console.WriteLine(Math.Abs(valueOfmonte - Math.PI));
            
            
        }

        public static double Triangle(Coordinates1 findTri)
        {
            double answer = Math.Sqrt((findTri.x * findTri.x) + (findTri.y * findTri.y));
            return answer;           
        }

        
    }
    struct Coordinates1
    {
        public double x, y;

        public Coordinates1(double ax, double ay)
        {
            x = ax;
            y = ay;
        }
        public Coordinates1(Random random)
        {
            
            x = random.NextDouble();
            y = random.NextDouble();
        }


    }



}
