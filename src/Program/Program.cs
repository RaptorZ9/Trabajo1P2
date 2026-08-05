public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Addition.Add(1, 2));
        Console.WriteLine(Subtraction.Subtract(3, 4));
        Console.WriteLine(Multiplication.Multiply(5, 6));
        Console.WriteLine(Division.Divide(7, 8));
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
// Esta clase implementa la operación resta
public class Subtraction
{
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}  

// Esta clase implementa la funcion de multiplicacion 
public class Multiplication
{
   public static int Multiply(int a, int b)
   {
       return a * b;
   }
}

