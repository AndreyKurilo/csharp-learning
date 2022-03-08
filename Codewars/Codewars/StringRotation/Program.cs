using Codewars;

class Program
{
    public static void Main(string[] args)
    {
        int shiftNumber = CalculateStringRotation.ShiftedDiff("coffee", "eecoff");
        Console.WriteLine("Characters we should shift the first string forward to match the second: " 
                      + shiftNumber);
    }
}