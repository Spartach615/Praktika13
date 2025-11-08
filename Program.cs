using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Praktika13
{
    //Задание 1
    public class Employee
    {
        public string Name { get; set; }
        public string Dol { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, string dol, decimal salary)
        {
            Name = name;
            Dol = dol;
            Salary = salary;
          
        }
        public void GetInfo()
        {
            Console.WriteLine($"Сотрудник: {Name}, Должность: {Dol}, Зарплата: {Salary }");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, decimal salary,  int teamSize) : base(name, "Менеджер", salary)
        {
            TeamSize = teamSize;
        }

        public void ConductMeeting()
        {
            Console.WriteLine($"{Name} проводит собрание с командой из {TeamSize} человек.");
        }
    }

    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, decimal salary, string language): base(name, "Разработчик", salary)
        {
            ProgrammingLanguage = language;
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} пишет код на {ProgrammingLanguage}.");
        }
    }

    public class Director : Employee
    {
        public string Department { get; set; }

        public Director(string name, decimal salary, string department): base(name, "Директор", salary)
        {
            Department = department;
        }

        public void ApproveBudget()
        {
            Console.WriteLine($"{Name} утвердил бюджет отдела '{Department}'.");
        }
    }
    //

    //Задание 2
   public class BankAccount
   {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Owner { get; set; }
   }
    public class CheckingAccount: BankAccount
    {
        public decimal OwerDraft {  get; set; }
        public void CheckAccount()
        {
            Console.WriteLine("Текущий счет: " +AccountNumber + ", овердрафт: " + OwerDraft);
        }
    }
    public class SavingsAccount  : BankAccount
    {
        public decimal ProcStavka {  get; set; }
        public void SavingAccount()
        {
            Console.WriteLine("Сберегательный счет: " +AccountNumber + ", ставка: " + ProcStavka);
        }
    }
    public class CreditAccount : BankAccount
    {
        public decimal CredLimit { get; set; }
        public decimal Date { get; set; }
       public void CrediAccount()
       {
        Console.WriteLine("Кредитный счет: " + AccountNumber + ", лимит: " + CredLimit);
       }
    }
    //

    //задание 3
    public class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class Book : LibraryItem
    {
        public int PageCount { get; set; }
        public string ISBN { get; set; }
    }

    public class Magazine : LibraryItem
    {
        public int Number { get; set; }
        public string Frequency { get; set; }
    }
    public class Audiobook : LibraryItem
    {
        public int Duration { get; set; }
        public string Narrator { get; set; }
    }
    public class DVD : LibraryItem
    {
        public int Duration { get; set; }
        public string Rating { get; set; }
    }

    //задание4
    public class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
    public class VideoCourse : Course
    {
        public int VideoCount { get; set; }
        public int TotalDuration { get; set; }
    }
    public class TextCourse : Course
    {
        public int ChapterCount { get; set; }
        public int TotalTextVolume { get; set; }
    }

    public class InteractiveCourse : Course
    {
        public int ExerciseCount { get; set; }
        public string CheckingSystem { get; set; }
    }
    //

    //задание 5
    public class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
    }
    public class Mammal : Animal
    {
        public string FurType { get; set; }
        public int GestationPeriod { get; set; } 
    }

    public class Bird : Animal
    {
        public double Wingspan { get; set; } 
        public string NestingType { get; set; }
    }

    public class Reptile : Animal
    {
        public string SkinType { get; set; }
        public double EnvironmentTemperature { get; set; } 
    }

   
    public class Fish : Animal
    {
        public string ScaleType { get; set; }
        public int HabitatDepth { get; set; } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Developer developer =new Developer ( "Кирилл Трунников", 150000m, "C#" );
            Manager manager = new Manager("Иван Иванов", 100000m, 10);
            Director director = new Director("Максим Максимов", 300000m, "ИТ");

            developer.GetInfo();
            developer.WriteCode();
            manager.GetInfo();
            manager.ConductMeeting();
            director.GetInfo();
            director.ApproveBudget();
            Console.WriteLine();
            //

            //Задание 2
            CheckingAccount checkingAccount = new CheckingAccount()
            {
                AccountNumber = "3456789",
                Balance = 100000,
                Owner = "КириллТрунников",
                OwerDraft = 500
            };
            checkingAccount.CheckAccount();
           SavingsAccount savingsAccount = new SavingsAccount()
            {
                AccountNumber = "876543",
                Balance = 0,
                Owner = "Иван Иванов",
                ProcStavka = 5
            };
            savingsAccount.SavingAccount();
            CreditAccount creditAccount = new CreditAccount()
            {
                AccountNumber = "0987654",
                Balance = 30000,
                Owner = "Максим Максимов",
                CredLimit = 10000,
                Date = 4
            };
            creditAccount.CrediAccount();
            Console.WriteLine();
            //

            //задание 3
            Book book = new Book
            {
                Title = "Белое дело в России: 1917-1919 гг.",
                Author = "В. Ж. Цветков",
                Year = 2000,
                PageCount = 2190,
                ISBN = "978-5-389-0237548-3"
            };

            Magazine magazine = new Magazine
            {
                Title = "Евгений Онегин",
                Author = "Пушкин",
                Year = 1831,
                Number = 3,
                Frequency = "ежемесячный"
            };

            DVD dvd = new DVD
            {
                Title = "Крестный отец",
                Author = "Фрэнсис Форд Коппола",
                Year = 1972,
                Duration = 175,
                Rating = "5.0"
            };

            Audiobook audiobook = new Audiobook
            {
                Title = "Барышня-крестьянка",
                Author = "Пушкин",
                Year = 1830,
                Duration = 52,
                Narrator = "Александр Теренков"
            };

            Console.WriteLine("Книга: " + book.Title + ", " + book.PageCount + " стр.");
            Console.WriteLine("Журнал: " + magazine.Title + ", выпуск " + magazine.Number);
            Console.WriteLine("DVD: " + dvd.Title + ", " + dvd.Duration + " мин.");
            Console.WriteLine("Аудиокнига: " + audiobook.Title + ", слушает " + audiobook.Narrator);
            Console.WriteLine();

            //задание 4
            VideoCourse videoCourse = new VideoCourse
            {
                Title = "Изучение C# ",
                Author = "Иван Иванов",
                Price = 5000,
                VideoCount = 25,
                TotalDuration = 300
            };

            TextCourse textCourse = new TextCourse
            {
                Title = "Практика по Unity",
                Author = "Максим Максимов",
                Price = 2232,
                ChapterCount = 124,
                TotalTextVolume = 1675
            };

            InteractiveCourse interactiveCourse = new InteractiveCourse
            {
                Title = "Java-разрабочик",
                Author = "Николай Васильев",
                Price = 4000,
                ExerciseCount = 125,
                CheckingSystem = "Автоматическая"
            };

            Console.WriteLine("Видео-курс: " + videoCourse.Title + ", " + videoCourse.VideoCount + " видео-упражнений");
            Console.WriteLine("Текстовый курс: " + textCourse.Title + ", " + textCourse.ChapterCount + " глав");
            Console.WriteLine("Интерактивный курс: " + interactiveCourse.Title + ", " + interactiveCourse.ExerciseCount + " упражнений");
            Console.WriteLine();
            //

            //задание5
            Mammal mammal = new Mammal
            {
                Species = "собака",
                Age = 13,
                Habitat = "суровым морозным климатом",
                Diet = "плотоядны",
                FurType = "тёмно-бурый",
                GestationPeriod = 65
            };

            Bird bird = new Bird
            {
                Species = "голубь",
                Age = 3,
                Habitat = "Горы или в городах",
                Diet = "всеядные",
                Wingspan = 0.6,
                NestingType = " карнизы и пустоты под крышами"
            };

            Reptile reptile = new Reptile
            {
                Species = "гадюка",
                Age = 5,
                Habitat = "Леса",
                Diet = "Хищник",
                SkinType = "Чешуя",
                EnvironmentTemperature = 25
            };

            Fish fish = new Fish
            {
                Species = "щука",
                Age = 25,
                Habitat = "Озера",
                Diet = "Хищник",
                ScaleType = "Циклоидная",
                HabitatDepth = 3
            };

            Console.WriteLine("Млекопитающее: " + mammal.Species + ", мех: " + mammal.FurType);
            Console.WriteLine("Птица: " + bird.Species + ", размах крыльев: " + bird.Wingspan);
            Console.WriteLine("Рептилия: " + reptile.Species + ", кожа: " + reptile.SkinType);
            Console.WriteLine("Рыба: " + fish.Species + ", чешуя: " + fish.ScaleType);
        }
    }
}
