/*

//Задание 1

using System;

public class program
{
    class student
    {
        public string surname { get; set; }
        public DateTime birthdate { get; set; }
        public int groupNum { get; set; }
        public int[] progress { get; set; }

        public void input()
        {
            Console.WriteLine("Введите фамилию");
            this.surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения (дд.мм.гггг)");
            string birthdateInput = Console.ReadLine();
            this.birthdate = DateTime.Parse(birthdateInput);
            Console.WriteLine("Введите номер группы");
            this.groupNum = Convert.ToInt32(Console.ReadLine());
            this.progress = new int[5] { 5, 4, 3, 5, 4 };
        }
        public void ChangeSurname(int choose)
        {

            Console.Write("Введите фамилию ");
            this.surname = Console.ReadLine();

        }
        public void ChangeDateBirth(int choose)
        {

            Console.Write("Введите дату рождения группы (дд.мм.гггг) ");
            string birthdateInput = Console.ReadLine();
            this.birthdate = DateTime.Parse(birthdateInput);

        }
        public void ChangeGroupNum(int choose)
        {

            Console.Write("Введите номер группы ");
            this.groupNum = Convert.ToInt32(Console.ReadLine());
        }
        public void printStudentInfo()
        {
            Console.WriteLine($"Фамилия студента {this.surname}");
            Console.WriteLine($"Дата рождения студента {this.birthdate:dd.MM.yyyy}");
            Console.WriteLine($"Номер группы {this.groupNum}");
            Console.WriteLine("Успеваемость студента");
            foreach (int a in this.progress)
            {
                Console.Write($" {a}");
            }

        }
        public static void Main(string[] args)
        {
            student student = new student();

            student.input();

           
            Console.WriteLine("Если вы хотите изменить фамилию введите 1");
            Console.WriteLine("Если вы хотите изменить дату рождения введите 2");
            Console.WriteLine("Если вы хотите изменить Номер группы введите 3");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                student.ChangeSurname(choose);
            }
            else if(choose == 2)
            {
                student.ChangeDateBirth(choose);
            }
            else if(choose == 3)
            {
                student.ChangeGroupNum(choose);
            }
            student.printStudentInfo();


        }
    }
}
*/



// Задание 2


/*
using System;

public class program
{
    class train
    {
        public string[] Destination { get; set; }
        public int[] TrainsNums { get; set; }
        public DateTime[] DepartureTime { get; set; }

        public void information()
        {
            string[] destination =
            {
                "Москва",
                "Томск",
                "Новосибирск",
                "Новгород",
                "Санкт-петербург"
            };
            this.Destination = destination;

            int[] trainsNums = { 6001, 6452, 6821, 6997, 7502 };
            this.TrainsNums = trainsNums;
            DateTime[] departureTime =
            {
                DateTime.Parse("15.02.2024 17:45"),
                DateTime.Parse("17.02.2024 12:20"),
                DateTime.Parse("19.02.2024 15:00"),
                DateTime.Parse("20.02.2024 19:55"),
                DateTime.Parse("21.02.2024 14:35")
            };
            this.DepartureTime = departureTime;

            outputTrainNums(this.TrainsNums); 

        }

        public void outputTrainNums(int[] trainsNums)
        {
            for(int i = 1; i <= TrainsNums.Length; i++)
            {
                Console.WriteLine($"{i}. номер поезда {trainsNums[i - 1]}");
            }
        }
        public void DisplayTrainInfo(int index)
        {
            Console.WriteLine($"Пункт назначения: {Destination[index - 1]}");
            Console.WriteLine($"Номер поезда: {TrainsNums[index - 1]}");
            Console.WriteLine($"Время отправления: {DepartureTime[index - 1]:dd.MM.yyyy HH:mm}");
        }

    }
    public static void Main(string[] args)
    {
        train train = new train();

        train.information();

        Console.WriteLine("Введите от 1 до 5 чтобы узнать информацию о выбранном поезде");
        int choose = Convert.ToInt32(Console.ReadLine());

        train.DisplayTrainInfo(choose);

    }
        
}
*/

//Задание 3

/*
using System;

public class program
{
    class number
    {
        public int num1{ get; set; }
        public int num2 { get; set; }

        public void numbers(int num1, int num2)
        {
            num1 = 10;
            this.num1 = num1;
            num2 = 15;
            this.num2 = num2;
        }

        public void EditNum(int newNum1, int newNum2)
        {
            this.num1 = newNum1;
            this.num2 = newNum2;
        }
        public void Output(int num1, int num2)
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
        public void sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine($"сумма чисел {sum}");
        }
        public void maxNum(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"максимальное число {num1}");
            }
            else if(num1 < num2)
            {
                Console.WriteLine($"максимальное число {num2}");
            }
        }
    }
    
    public static void Main(string[] args)
    {
        number number = new number();
        number.numbers(number.num1, number.num2);

        number.Output(number.num1, number.num2);

        Console.WriteLine("Если хотите изменить числа введите 1 ");
        int choose = Convert.ToInt32(Console.ReadLine());
        if(choose == 1)
        {
            Console.WriteLine("Вводите числа ");
            int newNum1 = Convert.ToInt32(Console.ReadLine());
            int newNum2 = Convert.ToInt32(Console.ReadLine());
            number.EditNum(newNum1, newNum2);
        }
        number.Output(number.num1, number.num2);

        number.sum(number.num1, number.num2);
        number.maxNum(number.num1, number.num2);



    }
}

*/

//Задание 4

/*
using System;

public class program
{
    class counter
    {
        public int value { get; set; }

        public void Increment()
        {
            value++;
        }
        public void Decrement()
        {
            value--;
        }

    }
    public static void Main(string[] args)
    {
        counter counter = new counter();
        counter.value = 0;
        Console.WriteLine("Если вы хотите ввести значения счетчика введите 1");

        int choose = Convert.ToInt32(Console.ReadLine());
        if(choose == 1)
        {
            Console.WriteLine("Введите значение счетчика");
            counter.value = Convert.ToInt32(Console.ReadLine());
        }

        counter.Increment();
        Console.WriteLine(counter.value);

        counter.Decrement();
        Console.WriteLine(counter.value);

    }
}

*/

//Задание 5

/*
using System;


public class program
{
    public class MyClass
    {
        public int property1 { get; set; }
        public string property2 { get; set; }

        public MyClass(int property1, string property2)
        {
            this.property1 = property1;
            this.property2 = property2;
        }

        ~MyClass() 
        {
            Console.WriteLine("Объект был удален", property1, property2);
        }
        public void Destroy(int property1, string property2)
        {
            MyClass des = new MyClass(property1, property2);
        }



    }

    public static void Main(string[] args)
    {
        MyClass myClass = new MyClass(65, "lalallala" );
        
        Console.WriteLine(myClass.property1);
        Console.WriteLine(myClass.property2);

        for(int i = 0; i < 12000000; i++) 
        {
            myClass.Destroy(myClass.property1, myClass.property2);
        }
     

    }
}

*/