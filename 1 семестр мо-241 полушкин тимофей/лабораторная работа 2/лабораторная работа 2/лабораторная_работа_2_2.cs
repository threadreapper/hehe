using System;
class HelloWorld
{
    static void Main() {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int max = (a + b + Math.Abs(a-b))/2;
        Console.WriteLine(max);
    }
    
}