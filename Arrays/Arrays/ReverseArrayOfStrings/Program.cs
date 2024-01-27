namespace ReverseArrayOfStrings;

class Program
{
    static void Main(string[] args)
    {
        string[] strArr = Console.ReadLine().Split();

        Console.WriteLine(string.Join(" ", strArr.Reverse()));
    }
}

