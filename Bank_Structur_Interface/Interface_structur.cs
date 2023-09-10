using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Structur_Interface
{

    interface ICanDoBankPersonal
    {
        public string position { get; set; }
    }

    interface ICanDoCEOManager
    {
        public void organize();
    }

    interface ICanDoCEO
    {
        public void MakeMeeting();
        public void decreasePercentage(int percent);
    }

    interface ICanDoWorker
    {
        public void StartTime(int start);
        public void EndTime(int end);
        public void Operations(string[] operations);
        public void AddOperation(string operation);
    }

    interface ICanDoManager
    {
        public void CalculateSalaries();
    }

    interface ICanDoClient
    {
        public void live_address(string address);
        public void work_address(string address);
    }

    internal class Operation
    {
        public Guid Id { get; set; }
        public string process_name { get; set; }
        public DateTime datatime { get; set; }

        public Operation(string name, DateTime time)
        {
            this.Id = Guid.NewGuid();
            this.process_name = name;
            this.datatime = time;
        }
    }
    internal abstract class Person
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int salary { get; set; }

        public Person(string Name, string Surname, int Age, int Salary)
        {
            this.Id = Guid.NewGuid();
            name = Name;
            surname = Surname;
            age = Age;
            salary = Salary;
        }

    }

    internal class CEO : Person, ICanDoBankPersonal, ICanDoCEO, ICanDoCEOManager
    {
        public string position { get; set; }


        public CEO(string Name, string Surname, int Age, int Salary, string Position) : base(Name, Surname, Age, Salary)
        {
            position = Position;
        }
        public void decreasePercentage(int percent)
        {
            Console.WriteLine("decreasePercentage");
        }

        public void MakeMeeting()
        {
            Console.WriteLine("MakeMeeting");
        }

        public void organize()
        {
            Console.WriteLine("Organize");
        }
    }

    internal class Worker : Person, ICanDoBankPersonal, ICanDoWorker
    {
        public string position { get; set; }

        public Worker(string Name, string Surname, int Age, int Salary, string Position) : base(Name, Surname, Age, Salary)
        {
            position = Position;
        }

        public void AddOperation(string operation)
        {
            Console.WriteLine("AddOperation");
        }

        public void StartTime(int start)
        {
            Console.WriteLine("StartTime");
        }

        public void EndTime(int end)
        {
            Console.WriteLine("EndTime");
        }

        public void Operations(string[] operations)
        {
            Console.WriteLine("Operations");
        }

    }

    internal class Manager : Person, ICanDoBankPersonal, ICanDoCEOManager, ICanDoManager
    {
        public string position { get; set; }

        public Manager(string Name, string Surname, int Age, int Salary, string Position) : base(Name, Surname, Age, Salary)
        {
            position = Position;
        }

        public void organize()
        {
            Console.WriteLine("Organize");
        }

        public void CalculateSalaries()
        {
            Console.WriteLine("CalculateSalaries");
        }
    }

    internal class Client : Person, ICanDoClient
    {
        public Client(string Name, string Surname, int Age, int Salary) : base(Name, Surname, Age, Salary)
        {
        }

        public void live_address(string address)
        {
            Console.WriteLine("Live_address");
        }

        public void work_address(string address)
        {
            Console.WriteLine("Work_address");
        }
    }

    internal class Credit
    {
        public Guid Id { get; set; }
        public int amount { get; set; }
        public Client? client { get; set; }
        public int percent { get; set; }
        public int months { get; set; }
        public Credit(int Amount, Client _client, int Percent, int Months)
        {
            Id = Guid.NewGuid();
            amount = Amount;
            client = _client;
            percent = Percent;
            months = Months;
        }

        public void calculatePercent()
        {
            Console.WriteLine("calculatePercante");
        }

        public void Payment()
        {
            Console.WriteLine("Payment");
        }
    }

    internal class Bank
    {
        public string name { get; set; }
        public int budget { get; set; }
        public int profit { get; set; }
        public CEO ceo { get; set; }
        public Manager[] managerrs { get; set; }
        public Worker[] workers { get; set; }
        public Client[] clients { get; set; }
        public Bank(string Name, int Budget, int Profit, CEO _ceo, Manager[] _managers, Worker[] _workers, Client[] _clients)
        {
            name = Name;
            budget = Budget;
            profit = Profit;
            ceo = _ceo;
            managerrs = _managers;
            workers = _workers;
            clients = _clients;
        }

        public void calculate_Profit()
        {
            Console.WriteLine("calculate_Profit");
        }
        public void showClientCredit(string fullname)
        {
            Console.WriteLine("showClientCredit");
        }
        public void payCredit(Client client,int money)
        {
            Console.WriteLine("payCredit");
        }
        public void ShowAllCredits()
        {
            Console.WriteLine("ShowAllCredits");
        }
    }
}
