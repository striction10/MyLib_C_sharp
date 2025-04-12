using MyMath = MyLib.Math;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool flag = true;
        double a, b, res;
        while (flag)
        {
            int val;
            Console.Write("Выберете действие: ");
            val = Convert.ToInt32(Console.ReadLine());
            switch (val)
            {
                case 1:
                    Console.Write("Введите A: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите B: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    res = MyMath.Add(a, b);
                    Console.WriteLine("Ответ: {0}", res);
                    break;
                case 2:
                    Console.Write("Введите A: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите B: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    res = MyMath.Subtract(a, b);
                    Console.WriteLine("Ответ: {0}", res);
                    break;
                case 3:
                    Console.Write("Введите A: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите B: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    res = MyMath.Multiply(a, b);
                    Console.WriteLine("Ответ: {0}", res);
                    break;
                case 4:
                    Console.Write("Введите A: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите B: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    res = MyMath.Divide(a, b);
                    Console.WriteLine("Ответ: {0}", res);
                    break;
                case 5:
                    Console.Write("Введите A: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите B: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    res = MyMath.Power(a, b);
                    Console.WriteLine("Ответ: {0}", res);
                    break;
                case 6:
                    Console.Write("Введите A: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    res = MyMath.Squar(a);
                    Console.WriteLine("Ответ: {0}", res);
                    break;
                default:
                    Console.Write("Введено неверное значение!");
                    break;
            }
            Console.Write("Продолжить: ");
            flag = Convert.ToBoolean(Console.ReadLine());
        }
    }
}