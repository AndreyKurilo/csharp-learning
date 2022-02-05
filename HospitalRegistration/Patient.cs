using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalRegistration
{
    class Patient
    {
        string name;
        string surname;
        string appointedDate;

        Patient (string name, string surname, string date)
        {
            this.name = name;
            this.surname = surname;
            appointedDate = date;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setAppointedDate(string date)
        {
            appointedDate = date;
        }

        public void showPatient()
        {
            Console.WriteLine($"Patient {name} {surname} has appointment on {appointedDate}");
        }


    }
}
