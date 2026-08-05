public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Addition.Add(1, 2));
        Console.WriteLine(Subtraction.Subtract(3, 4));
        Console.WriteLine(Multiplication.Multiply(5, 6));
        Console.WriteLine(Division.Divide(7, 8));
    }

    public class Subtraction
    {
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }  
}
