using System;

namespace JobLessonOOP05v01Part01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("++++++++++++++Разделитель. Далее деление на 0 ++++++++++++++");
            RationalNumber rationalNumber001 = new RationalNumber(25, 0);//Вводим первое рациональное число
            Console.WriteLine(rationalNumber001.ToString()); //Знаменатель не может быть равен нулю 1/0

            Console.WriteLine("++++++++++++++Разделитель. Далее вывод дробей ++++++++++++++");
            RationalNumber rationalNumber002 = new RationalNumber(5,13);//Вводим второе рациональное число
            Console.WriteLine(rationalNumber002.ToString()); //5/13
            RationalNumber rationalNumber003 = new RationalNumber(7,9);//Вводим третье рациональное число
            Console.WriteLine(rationalNumber003.ToString());//7/9
            RationalNumber rationalNumber004 = new RationalNumber(7, 9);//Вводим четвёртое рациональное число

            Console.WriteLine("++++++++++++++Разделитель. Далее == != и Equals ++++++++++++++");
            //будевы операции над числами
            Console.WriteLine(rationalNumber002 == rationalNumber003);//falce
            Console.WriteLine(rationalNumber002 != rationalNumber003);//true
            Console.WriteLine(rationalNumber001.Equals(rationalNumber002));//falce
            Console.WriteLine(rationalNumber002.Equals(rationalNumber003));//falce

            Console.WriteLine("++++++++++++++Разделитель. Далее > и < ++++++++++++++");
            Console.WriteLine(rationalNumber003 > rationalNumber001);//false
            Console.WriteLine(rationalNumber003 > rationalNumber002);//true
            Console.WriteLine(rationalNumber003 < rationalNumber002);//false

            Console.WriteLine("++++++++++++++Разделитель. Далее >= и <= ++++++++++++++");
            //арифметические операции над числами
            Console.WriteLine(rationalNumber003 <= rationalNumber004);//равны - true
            Console.WriteLine(rationalNumber002 <= rationalNumber004);//меньше - true
            Console.WriteLine(rationalNumber004 >= rationalNumber002);//больше - true

            Console.WriteLine("++++++++++++++Разделитель. Далее + - * / ++++++++++++++");
            Console.WriteLine(rationalNumber002+rationalNumber003);//136/117
            Console.WriteLine(rationalNumber002-rationalNumber003);//46/-117
            Console.WriteLine(rationalNumber002 * rationalNumber003);//35/117
            Console.WriteLine(rationalNumber002 / rationalNumber003);//45/91

            Console.WriteLine("++++++++++++++Разделитель. Далее ++ и -- ++++++++++++++");
            Console.WriteLine(rationalNumber002++);//5/13
            Console.WriteLine(rationalNumber002--);//5/13+13/13=18/13

            Console.WriteLine("++++++++++++++Разделитель. Далее float и int ++++++++++++++");
            RationalNumber rationalNumber005 = new RationalNumber(510000000, 5);
            Console.WriteLine((float)rationalNumber005);//1,02E+08
            Console.WriteLine((int)rationalNumber005);//102000000


            RationalNumber rationalNumber006 = new RationalNumber(36,19);
            RationalNumber rationalNumber007 = new RationalNumber(2, 5);
            Console.WriteLine(rationalNumber006%rationalNumber007);//4/1

            Console.ReadLine();
        }
    }
}
