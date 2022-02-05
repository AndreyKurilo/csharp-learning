using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalRegistration
{
    class Bot
    {
        private string date = null;

        public void questioning()
        {
            string name, surname;
            char sanction = 'Y';

            while(sanction != 'N')
            {
                Console.WriteLine("Would You like to register? Y/N");
                sanction = (char) Console.Read();
                if (sanction == 'Y' | sanction == 'y')
                {
                    Console.WriteLine("Enter Your name, please");
                    name = Console.ReadLine();
                    Console.WriteLine("Entered name: " + name);
                    if (validate(name))
                    {
                        Console.WriteLine("Enter Your surname, please");
                        surname = Console.ReadLine();
                        if (validate(surname))
                        {
                            Console.WriteLine("Enter date for admittance dd/mm/yyyy");
                            Console.WriteLine("For example - February 1st 2000: 01/02/2000 ");
                            date = Console.ReadLine();
                            if (AppointedDate.validate(date)) sanction = 'N';
                        }
                    }
                }
                else sanction = 'N';
            }
        }

        public void answering()
        {
            if (date != null)
            {
                if (AppointedDate.verify(date))
                {
                    Random rnd = new Random();
                    int hour = rnd.Next(9, 18);
                    int min = rnd.Next(0, 59);
                    Console.WriteLine("Your are registered on " + date + " at " + hour + ":" + min);
                }
                else Console.WriteLine("Registration available only the date later then now");
            }
            else Console.WriteLine("User has stopped program executing");
        }

        private bool validate(string value)
        {
            for(byte i = 0; i < value.Length; i++)
            {
                if (!Char.IsLetter(value[i]))
                {
                    Console.WriteLine("Wrong record - name & surname must have char's symbols only");
                    return false;
                }
            }
            return true;
        }
    }
}
