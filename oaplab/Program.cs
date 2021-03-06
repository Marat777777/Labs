// подключены какие-то библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace такой же как и название проекта
namespace oapLabaMarat
{
    // про классы мы пока не говорили...
    /*class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person { Name = "Tom", Age = 17 };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.Read();
        }
    }
    class Person
    {
        private int age;
        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new Exception("Лицам до 18 регистрация запрещена");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
    }
    */
    class Program
    {
        // точка входа в программу
        static void Main(string[] args)
        {
            //ExceptionExample();
            //ExceptionExample2();
            //ExceptionExample3();
            //ExceptionExample4();
            //ExceptionExample5();
            //ExceptionExample6();
            //ExceptionExample7();
            //ExceptionExample8();
            //ExceptionExample9();
            //ExceptionExample10();
            //ExceptionExample11();
            //ExceptionExample12();
            //ExceptionExample13();
            //ExceptionExample14();
            //ExceptionExample15();
            //ExceptionExample16();
            //ExceptionExample17();
            //ExceptionExample18();
            ExceptionExample19();
            Console.ReadKey();
        }
        static void ExceptionExample()
        {
            int x = 5;
            int y = x / 0;
            Console.WriteLine($"Результат: {y}");
            Console.WriteLine("Конец программы");
            Console.Read();
        }
        static void ExceptionExample2()
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");
            Console.Read();
        }
        static void ExceptionExample3()
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
        }
        static void ExceptionExample4()
        {
            Console.WriteLine("Введите число");
            int x = Int32.Parse(Console.ReadLine());

            x *= x;
            Console.WriteLine("Квадрат числа: " + x);
            Console.Read();
        }
        static void ExceptionExample5()
        {
            Console.WriteLine("Введите число");
            int x;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out x))
            {
                x *= x;
                Console.WriteLine("Квадрат числа: " + x);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.Read();
        }
        static void ExceptionExample6()
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
        }
        static void ExceptionExample7()
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Возникло исключение {ex.Message}");
            }
        }
        static void ExceptionExample8()
        {
            int x = 1;
            int y = 0;

            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException) when (y == 0 && x == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ExceptionExample9()
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }

            Console.Read();
        }
        static void ExceptionExample10()
        {
            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;     // IndexOutOfRangeException

                int x = 5;
                int y = x / 0;  // DivideByZeroException
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
        static void ExceptionExample11()
        {
            try
            {
                object obj = "you";
                int num = (int)obj;     // InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }

            Console.Read();
        }
        static void ExceptionExample12()
        {
            try
            {
                object obj = "you";
                int num = (int)obj;     // InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            Console.Read();

        }
        static void ExceptionExample13()
        {
            int? a = 42;
            if (a is int valueOfA)
            {
                Console.WriteLine($"a is {valueOfA}");
            }
            else
            {
                Console.WriteLine("a does not have a value");
            }
        }
        static void ExceptionExample14()
        {
            int? b = null;
            if (b.HasValue)
            {
                Console.WriteLine($"b is {b.Value}");
            }
            else
            {
                Console.WriteLine("b does not have a value");
            }
        }
        static void ExceptionExample15()
        {
            int? c = 7;
            if (c != null)
            {
                Console.WriteLine($"c is {c.Value}");
            }
            else
            {
                Console.WriteLine("c does not have a value");
            }
        }
        static void ExceptionExample16()
        {
            int? a = 28;
            int b = a ?? -1;
            Console.WriteLine($"b is {b}");  // output: b is 28

            int? c = null;
            int d = c ?? -1;
            Console.WriteLine($"d is {d}");  // output: d is -1
        }
        static void ExceptionExample17()
        {
            int? a = 10;
            Console.WriteLine($"{a} >= null is {a >= null}");
            Console.WriteLine($"{a} < null is {a < null}");
            Console.WriteLine($"{a} == null is {a == null}");
            // Output:
            // 10 >= null is False
            // 10 < null is False
            // 10 == null is False

            int? b = null;
            int? c = null;
            Console.WriteLine($"null >= null is {b >= c}");
            Console.WriteLine($"null == null is {b == c}");
            // Output:
            // null >= null is False
            // null == null is True
        }
        static void ExceptionExample18()
        {
            int a = 41;
            object aBoxed = a;
            int? aNullable = (int?)aBoxed;
            Console.WriteLine($"Value of aNullable: {aNullable}");

            object aNullableBoxed = aNullable;
            if (aNullableBoxed is int valueOfA)
            {
                Console.WriteLine($"aNullableBoxed is boxed int: {valueOfA}");
            }
            // Output:
            // Value of aNullable: 41
            // aNullableBoxed is boxed int: 41
        }
        static void ExceptionExample19()
        {
            object z = 200;
            object t = z ?? 44;
            Console.WriteLine(t);
        }

    }
}