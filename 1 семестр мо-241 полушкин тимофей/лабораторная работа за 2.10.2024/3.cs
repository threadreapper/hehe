using System;
class Third
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int maxima = -9999999;
        int maximaComparison = 0;
        for (int i = 0; i < n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                maximaComparison++;
            }
            else
            {
                maxima = Math.Max(maxima, maximaComparison);
                maximaComparison = 0;
            }
        }
        maxima = Math.Max(maxima, maximaComparison);

        Console.WriteLine(maxima);
    }
}