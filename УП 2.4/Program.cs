using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    class Number
    {
        public Dictionary<string, int> romanNumber { get; set; }
        public void Numbering()
        {

            romanNumber = new Dictionary<string, int>
            {
                {"I", 1 },
                {"IV", 4 },
                {"V", 5 },
                {"IX", 9 },
                {"X", 10 },
                { "XL", 40 },
                {"L", 50 },
                {"XC", 90 },
                {"C", 100 },
                { "CD", 400 },
                {"D", 500 },
                { "CM", 900 },
                {"M", 1000 },
            };

        }

        public void AddNewNumbers(int thousands, int hundreds, int tens, int units)
        {
            string Num = "M";
            if (thousands < 1000)
            {
                Num = null;
            }
            else
            {
                for (int i = 1000; i < thousands; i += 1000)
                {
                    Num += "M";
                    romanNumber.Add(Num, i);
                    
                }
            }

            string Num2 = "";
            if (hundreds < 100)
            {
                Num2 = Num;
            }
            else
            {
                if (hundreds >= 100 && hundreds <= 300)
                {
                    Num2 = "C";
                    for (int i = 100; i < hundreds; i += 100)
                    {
                        Num2 += "C";
                        romanNumber.Add(Num2, i);
                    }
                }
                else if (hundreds == 400)
                {
                    Num2 = "CD";
                }
                else if (hundreds > 300 && hundreds <= 800)
                {
                    Num2 = "D";
                    for (int i = 500; i < hundreds; i += 100)
                    {
                        Num2 += "C";
                    }
                }
                else if (hundreds == 900)
                {
                    Num2 = "CM";
                }
            }

            string Num3 = "";
            if (tens < 10)
            {
                Num3 = Num2;
            }
            else
            {
                if (tens >= 10 && tens <= 40)
                {
                    Num3 = "X";
                    for (int i = 10; i < tens; i += 10)
                    {
                        Num3 += "X";
                    }
                }
                else if (tens == 40)
                {
                    Num3 = "XL";
                }
                else if (tens > 40 && tens <= 80)
                {
                    Num3 = "L";
                    for (int i = 50; i < tens; i += 10)
                    {
                        Num3 += "X";
                    }
                }
                else if (tens == 90)
                {
                    Num3 = "XC";
                }
            }

            string Num4 = "";
            if (units < 1)
            {
                Num4 = "";
            }
            else
            {
                if (units > 1 && units <= 3)
                {
                    for (int i = 1; i <= units; i++)
                    {
                        Num4 += "I";
                    }
                }
                else if (units == 4)
                {
                    Num4 = "IV";
                }
                else if (units == 5)
                {
                    Num4 = "V";
                }
                else if (units > 5 && units <= 8)
                {
                    Num4 = "V";
                    for (int i = 5; i < units; i++)
                    {
                        Num4 += "I";
                    }
                }
                else if (units == 9)
                {
                    Num4 = "IX";
                }
            }

            string newKey = Num + Num2 + Num3 + Num4;
            int num = thousands + hundreds + tens + units;
            if (romanNumber.ContainsKey(newKey))
            {
                num = romanNumber[newKey];
            }
            romanNumber.Add(newKey, num);
        }


        public void SplitTheNumber(int num)
        {
            int thousands = num / 1000;
            num %= 1000;
            thousands = thousands * 1000;
            int hundreds = num / 100;
            num %= 100;
            hundreds = hundreds * 100;
            int tens = num / 10;
            tens = tens * 10;
            int units = num % 10;
            AddNewNumbers(thousands, hundreds, tens, units);

        }
        public void RomanToArabic(string romeNum)
        {
            int result = 0;
            for(int i = 0;  i < romeNum.Length; i++)
            {
                if(i + 1 < romeNum.Length && romanNumber[romeNum[i].ToString()] < romanNumber[romeNum[i + 1].ToString()])
                {
                    result -= romanNumber[romeNum[i].ToString()];
                }
                else
                {
                    result += romanNumber[romeNum[i].ToString()];
                }
                
            }
            Console.WriteLine(result);
        }

        public static void Main(string[] args)
        {
            Number number = new Number();

            int num = 1993;

            string romeNum = "MCMXCIV"; 

            number.Numbering();
            number.SplitTheNumber(num);
            number.RomanToArabic(romeNum);
            foreach ((string key, int value) in number.romanNumber)
            {
                if(value == num)
                {
                    Console.WriteLine($"{key} - {value}");
                }
               
            }

        }
    }
}