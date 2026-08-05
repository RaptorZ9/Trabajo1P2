public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Addition.Add(1, 2));
        Console.WriteLine(Subtraction.Subtract(3, 4));
        Console.WriteLine(Multiplication.Multiply(5, 6));
        Console.WriteLine(Division.Divide(7, 8));
    }
}
// Esta clase implementa la multiplicacion
public class Multiplication
{
   public static int Multiply(int a, int b)
   {
       return a * b;
   }
}