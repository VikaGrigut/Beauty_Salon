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
        public string date_of_birth;
        public Status status;
        public double balance;
        public string phone_number;
        public List<string> history ;

        public Client()
        {
            this.first_name = "Неопределено";
            this.last_name = "Неопределено";
            this.date_of_birth = "Неопределено";
            this.status = Status.Новый;
            this.balance = 0;
            this.phone_number = "Неопределён";

            
        }
        public Client(string first_name, string last_name, int day, int month, int year, int status, double balance, string phone_number)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            DateTime adate = new DateTime(year, month, day);
            this.date_of_birth = adate.ToString("d");
            this.status = (Status)status;
            this.balance = balance;
            this.phone_number = phone_number;
        }
        public void Add_Client()
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string last_name = Console.ReadLine();
            Console.WriteLine("Введите дату рождения (день.месяц.год): ");
            string data = Console.ReadLine();
            data.Split(".");
            DateTime adate = new DateTime(data[0], data[1], data[2]);
            Console.WriteLine("Выберете статус: \n1.Новый;\n2.Постоянный;\n3.VIP;\n");
            int status = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер телефона: ");
            string phone_number = Console.ReadLine(); 
            Console.WriteLine("Введите баланс: ");
            int balance = int.Parse(Console.ReadLine());
            this.date_of_birth = adate.ToString("d");
            this.first_name = name;
            this.last_name = last_name;
            this.status = (Status)status;
            this.balance = balance;
            this.phone_number = phone_number;
        }
    }
}
