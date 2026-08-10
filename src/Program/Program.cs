public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Addition.Add(1, 2));
        // esto llama la suma
        Console.WriteLine(Subtraction.Subtract(3, 4));
        // esto llama la resta
        Console.WriteLine(Multiplication.Multiply(5, 6));
        // esto llama la multiplicación
        Console.WriteLine(Division.Divide(7, 8));
        // esto llama la división + cambio incorrecto
    }
// Esta clase implementa la operación divide    
    public class Division
    {
    public static double Divide(int a, int b)
    {
        return (double)a / b;
    }
    }

}
