namespace ConsoleApp1;

public class Utils
{
    public static void BreakLine()
    {
        Console.WriteLine("\n-----------------------------------\n");
    }

    public static List<string> GetNumbers() { 
    
        var list = new List<string>();
        for (int i = 0; i < 10; i++) { 
            list.Add($"{i}");
        }
        return list;
    }
}
