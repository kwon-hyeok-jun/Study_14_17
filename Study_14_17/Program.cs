using System;
using static System.Console;

/*
class SwitchStatement
{
    static void Main(string[] args)
    {
        WriteLine("가장 좋아하는 프로그래밍 언어는?");
        Write("1. C\t");
        Write("2. C++\t");
        Write("3. C#\t");
        Write("4. Java\t");

        int choice = Convert.ToInt32(ReadLine());

        switch(choice)
        {
            case 1:
                WriteLine("C 선택");
                break;
            case 2:
                WriteLine("C++ 선택");
                break;
            case 3:
                WriteLine("C# 선택");
                break;
            case 4:
                WriteLine("Java 선택");
                break;
            default:
                WriteLine("c, c++, c#, java가 아니다.");
                break;
        }
    }
}
*/

/*
class ForDescription
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("안녕하세요.");
        }
    }
}
*/


/*
class ForDemo
{
    static void Main(string[] args)
    {
        for(int i = 1; i <= 5; i++)
        {
            Console.Write("{0}\t", i);
            if (i % 3 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();

        int sum1 = 0;
        for(int i = 1; i <= 100; i++)
        {
            sum1 += i;
        }
        Console.WriteLine($"1부터 100까지의 합은 {sum1} 입니다.");
        Console.WriteLine();

        int sum2 = 0;
        for(int i = 1; i <= 100; i++)
        {
            if(i%2 == 0)
            {
                sum2 += i;
            }
        }
        Console.WriteLine($"1부터 100까지 짝수의 합은 {sum2}입니다.");
    }
}
*/

/*
class WhileFibonacci
{
    static void Main(string[] args)
    {
        int first = 0;
        int second = 1;

        while (second <= 20)
        {
            Console.WriteLine(second);
            int temp = first + second;
            first = second;
            second = temp;
        }
    }
}
*/

/*
class Dowhile
{
    static void Main(string[] args)
    {
        int count = 0;
        do
        {
            Console.WriteLine("안녕하세요.");
            count++;
        }while (count <= 10);
    }
}
*/

/*
class ForEach
{
    static void Main(string[] args)
    {
        string str = "ABC123";

        //foreach (char c in str)
        foreach (var c in str)
        {
            Console.Write($"{c}\t");
        }
        Console.WriteLine();
    }
}
*/

/*
class BrakDemo
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 100; i++)
        {
            if(i == 5)
            {
                break;
            }
            Console.WriteLine($"현재 i의 값은 {i} 입니다. " );
        }
        Console.WriteLine("break");
    }
}
*/

/*
class ContinueDemo
{
    static void Main(string[] args)
    {
        for(int i = 0; i <= 5; i++)
        {
            if(i % 2 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
*/
