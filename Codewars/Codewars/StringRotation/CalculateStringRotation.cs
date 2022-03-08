namespace Codewars;

public class CalculateStringRotation
{
    public static int ShiftedDiff(string first, string second)
    {
        int i = 0;
        string secondProcess;
        while (!first.Equals(second))
        {
            char[] chars = second.ToCharArray();
            secondProcess = second.Remove(0,1);
            second = secondProcess + chars[0];
            Console.WriteLine(second);
            i++;
        }
        return i;
    }
}