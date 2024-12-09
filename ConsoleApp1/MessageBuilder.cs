namespace ConsoleApp1;

public class MessageBuilder
{ 

    public static void WelcomeMessage()
    {
        Console.WriteLine("Digite o seu nome: ");
        var name = Console.ReadLine();

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }

    public static void FullName()
    {
        Console.WriteLine("Digite o seu nome: ");
        var firstName = Console.ReadLine();

        Utils.BreakLine();
        
        Console.WriteLine("Digite o seu sobrenome: ");
        var lastName = Console.ReadLine();

        Utils.BreakLine();

        Console.WriteLine($"{firstName} {lastName}");
    }
}
