using System;
using System.Collections.Generic;
using System.Text;

namespace Beauty_Salon
{
    public enum Status
    {
        Новый = 1,
        Постоянный = 2,
        VIP = 3
    }
    public class Client
    {
        public string first_name;
        public string last_name;
        public String date_of_birth;
        public Status status;
        public double balance;
        public string phone_number;
        public string[] histore = new string[1];

        public Client()
        {
            this.first_name = "Aleksanra";
            this.last_name = "Goncharik";
            DateTime adate = new DateTime(2004, 02, 22);
            this.date_of_birth = adate.ToString("D");
            this.status = Status.Новый;
            this.balance = 500;
            this.phone_number = "+375297850414";
            //heloo fuck

            
        }
        public Client(string first_name, string last_name, int day, int month, int year, int status, double balance, string phone_number)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            DateTime adate = new DateTime(year, month, day);
            this.date_of_birth = adate.ToString("d");
            switch (status)
            {
                case 1:
                    this.status = Status.Новый;
                    break;
                case 2:
                    this.status = Status.Постоянный;
                    break;
                case 3:
                    this.status = Status.VIP;
                    break;
            }
            this.balance = balance;
            this.phone_number = phone_number;
        }
    }
}
