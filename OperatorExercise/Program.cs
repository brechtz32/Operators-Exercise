namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine($"What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

        
    }
}
