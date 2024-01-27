namespace DayOfWeek;

class Program
{
    static void Main(string[] args)
    {
        string[] daysOfWeek =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sundat"
        };

        int num = int.Parse(Console.ReadLine());

        if (num < 1 || num >= daysOfWeek.Length)
        {
            Console.WriteLine("Invalid day!");
        }
        else
        {
            Console.WriteLine(daysOfWeek[num - 1]);
        }
    }
}

