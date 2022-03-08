namespace Clock_in_Mirror;

public class Kata
{
    public static string WhatIsTheTime(string timeInMirror)
    {
        int hours;
        string minutes;
        var min = 60 - int.Parse(timeInMirror.Substring(3));

        if (min is 0 or 60)
        {
            hours = 12 - int.Parse((timeInMirror.Substring(0, 2)));
            minutes = "00";
            if (hours == 0)
            {
                hours = 12;
            }

            if (hours < 10)
            {
                return "0" + hours + ":" + minutes;
            }
            return hours + ":" + minutes;
        }
        
        hours = 11 - int.Parse((timeInMirror.Substring(0, 2)));

        if (min is > 0 and < 10)
        {
            minutes = "0" + min;
        }
        else
        {
            minutes = "" + min;
        }

        switch (hours)
        {
            case 0:
                hours = 12;
                return hours + ":" + minutes;
            case -1:
                hours = 11;
                return hours + ":" + minutes;
            case 10:
                return hours + ":" + minutes;
        }

        return "0" + hours + ":" + minutes;
    }
}