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
    class Program
    {
        // точка входа в программу
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input Nomer: ");
                string InpNomer = Console.ReadLine();
                if (InpNomer.Length == 0)
                    break;
                char[] GosNomerSimb = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'O', 'P', 'T', 'X', 'Y' };
                if (InpNomer.Length == 6)
                {
                    var ValidNumber = true;
                    for (int i = 0; i < 6 & ValidNumber; i++)
                    {
                        if (i == 1 | i == 2 | i == 3)
                            ValidNumber &= Char.IsDigit(InpNomer[i]);
                        else
                            ValidNumber &= (InpNomer[i].ToString().IndexOfAny(GosNomerSimb) >= 0);
                    }
                    Console.Write(ValidNumber ? "номер верный\n" : "номер не верный\n");
                }
                else
                {
                    Console.Write("такой номер не существует");
                    
                }
            }
            //к сожалению, на остальное не хватает какого-то пинка)