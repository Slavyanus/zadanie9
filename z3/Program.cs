// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;
 
public class Test
{
        public static int recursion(int m, int n)
    {
        // Базовый случай
        if (m == 0)
        {
            return n + 1;
        } // Шаг рекурсии / рекурсивное условие
        else if (n == 0 && m > 0)
        {
            return recursion(m - 1, 1);
        } // Шаг рекурсии / рекурсивное условие
        else
        {
            return recursion(m - 1, recursion(m, n - 1));
        }
    }
    
        static int Ack(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return Ack(m - 1, 1);
            }
            else
            {
                return Ack(m - 1, Ack(m, n - 1));
            }
 
        }
  
    public static void Main()
    {
       
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        Console.Write(recursion(m, n)); // вызов рекурсивной функции
        Console.Write(Ack(m, n)); // вызов рекурсивной функции
       
    }
 
 
    }