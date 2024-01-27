namespace Rounding;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] inputArr = input.Split();

        double[] doubleArr = inputArr.Select(double.Parse).ToArray();

        //for (int i = 0; i < doubleArr.Length; i++)
        //{
        //  doubleArr[i] = Math.Round(doubleArr[i], MidpointRounding.AwayFromZero);
        //}

        doubleArr = doubleArr.Select(num => Math.Round(num, MidpointRounding.AwayFromZero)).ToArray();

        Console.WriteLine(string.Join(" ", doubleArr));
    }
}

