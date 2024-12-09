using System.Globalization;
using System.Linq;

namespace ConsoleApp1;

public class Questoes
{
    public static void Questao1() => MessageBuilder.WelcomeMessage();
    public static void Questao2() => MessageBuilder.FullName();
    public static void Questao3()
    {
        var soma = Calculadora.Soma(7, 3);
        var subtracao = Calculadora.Subtrair(7, 3);
        var media = Calculadora.Media(7, 3);
        var multiplicacao = Calculadora.Multiplicar(7, 3);
        var divisao = Calculadora.Divisao(7, 3);

        Console.WriteLine($"{soma}, {subtracao}, {media} ,{multiplicacao} ,{divisao}");
        Utils.BreakLine();
    }
    public static void Questao4()
    {

        Console.WriteLine("Digite uma frase: ");
        var phrase = Console.ReadLine();

        var phraseCount = phrase is not null ? phrase.Length : 0;
        Console.WriteLine($"Quantidade de caracteres: {phraseCount}");
    }

    public static void Questao5()
    {
        Console.WriteLine("Digite a placa do seu carro: ");
        var plate = Console.ReadLine();

        if (plate is null || plate.Length != 7)
        {
            Console.WriteLine("Invalido");
            return;
        }

        var numbers = Utils.GetNumbers();
        var valid = true;
        for (var i = 0; i < 7; i++)
        {
            var item = plate[i].ToString();
            if (i < 3 && numbers.Contains(item))
            {
                valid = false;
                break;
            }

            if (i >= 3 && !numbers.Contains(item))
            {
                valid = false;
                break;
            }

        }

        var message = valid ? "Valido" : "Invalido";
        Console.WriteLine(message);
    }

    public static void Questao6()
    {
        var date = DateTime.Now;

        var date1 = date.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR"));
        var date2 = date.ToString("dd/MM/yyyy");
        var date3 = date.ToString("HH:mm:ss");
        var date4 = date.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);
    }
}