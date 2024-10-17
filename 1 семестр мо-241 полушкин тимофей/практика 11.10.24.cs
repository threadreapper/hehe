using System;
class Practice
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        int invertedInt = 0;

        while (input > 0)
        {
            if (input / 10 == 0 && input % 2 != 0)
            {
                invertedInt = invertedInt * 10 + input % 10;
                Console.WriteLine(invertedInt);
                invertedInt = 0;
                input = Convert.ToInt32(Console.ReadLine());

            }
            else if (input / 10 == 0 && input % 2 == 0)
            {
                Console.WriteLine(invertedInt);
                invertedInt = 0;
                input = Convert.ToInt32(Console.ReadLine());
            }
            if (input % 2 != 0)
            {
                invertedInt = invertedInt * 10 + input % 10;
                input /= 10;
            }
            else
            {
                input /= 10;
            }
        }
        Console.WriteLine("ПОКА");

    }
}
