namespace ConsoleApp1;

public class Calculadora
{
    public static double Soma(double a, double b) => a + b;
    public static double Subtrair(double a, double b) => a - b;
    public static double Multiplicar(double a, double b) => a * b;
    public static double Media(double a, double b) => (a + b)/2;
    public static double Divisao(double a, double b)
    {
        if (b == 0) return 0;

        return a / b;
    }
}
