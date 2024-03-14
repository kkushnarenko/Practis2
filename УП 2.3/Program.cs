//Задание 1

/*
using System;

public class program
{
    class Worker
    {
        public string name {  get; set; }
        public string surname { get; set; }
        public int rate { get; set; }
        public int days { get; set; }

        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }
        public int GetSalary(int rate, int days)
        {
            int salary =(rate * days);
            return salary;
        }

    }
    public static void Main(string[] args)
    {
        Worker worker = new Worker("Иван", "Иванов", 8, 14);
        Console.WriteLine($"Имя работника {worker.name}");
        Console.WriteLine($"Фамилия работника {worker.surname}");
        Console.WriteLine($"Cтавка в день работника {worker.rate} часов");
        Console.WriteLine($"Отработанные дни работника {worker.days} дней");

        int salary = worker.GetSalary(worker.rate, worker.days);
        Console.WriteLine($"заработная плата работника {salary} рублей");
    }
}
*/


//Задание 2

/*
using System;

public class program
{
    class Worker
    {
        private string name { get; set; }
        private string surname { get; set; }
        private int rate { get; set; }
        private int days { get; set; }

        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }
        public int Rate
        {
             get { return rate; }
        }
        public int Days
        {
            get { return days; }
        }
        public string Name 
        {
            get { return name; } 
        }
        public string Surname
        {
            get { return surname; }
        }
        public int GetSalary(int rate, int days)
        {
            int salary = (rate * days);
            return salary;
        }

    }

    public static void Main(string[] args)
    {
        Worker worker = new Worker("Иван", "Иванов", 8, 14);
        Console.WriteLine($"Имя работника {worker.Name}");
        Console.WriteLine($"Фамилия работника {worker.Surname}");
        Console.WriteLine($"Cтавка в день работника {worker.Rate} часов");
        Console.WriteLine($"Отработанные дни работника {worker.Days} дней");

        int salary = worker.GetSalary(worker.Rate, worker.Days);
        Console.WriteLine($"заработная плата работника {salary} рублей");

    }
}

*/


//Задание 3

/*
using System;

public class program
{
    class Calculation
    {
        public string calculationLine { get; set; }

        public Calculation(string calculationLine)
        {
            this.calculationLine = calculationLine;
        }

        public void SetCalculationLine()
        {
            // изменяет свойство

            string newCalculationLine = Console.ReadLine();
            this.calculationLine = newCalculationLine;
        }

        public void SetLastSymbolCalculationLine()
        {
            // прибавляет символ в конец строки

            char endLine = Convert.ToChar(Console.ReadLine());
            calculationLine += endLine;
        }

        public void GetCalculationLine()
        {
            // вывод значение свойства

            Console.WriteLine($"{calculationLine}");

        }
        public void GetLastSymbol()
        {
            // получение последнего символа
            char lastSymbol = calculationLine[calculationLine.Length - 1 ];
            Console.WriteLine(lastSymbol);
        }
        public void DeleteLastSymbol()
        {
            // удаление последнего символа
            string newCalculationLine = calculationLine.Remove(calculationLine.Length - 1);
            this.calculationLine = newCalculationLine;
        }
    }

    public static void Main(string[] args)
    {
        Calculation calculation = new Calculation("fdfdfddsa");

        Console.WriteLine("Исходная строка");
        calculation.GetCalculationLine();

        Console.WriteLine("Если хотите изменить строку введите 1");
        int choose = Convert.ToInt32(Console.ReadLine());
        if (choose == 1) 
        {
            calculation.SetCalculationLine();
            Console.WriteLine("Измененная строка");
            calculation.GetCalculationLine();
        }
        
        
        Console.WriteLine("Введите один символ");
        calculation.SetLastSymbolCalculationLine();
        Console.WriteLine("Строка с добавленным символом в конце");
        calculation.GetCalculationLine();

        calculation.DeleteLastSymbol();
        Console.WriteLine("Строка с удаленным последним символом");
        calculation.GetCalculationLine();


        Console.WriteLine("Полученный символ в конце строки");
        calculation.GetLastSymbol();
        
    }
}

*/

