using System;
class First {
    static void Main() {
        int n = Convert.ToInt32(Console.ReadLine());
        int counter = 0;
        int comparisonCounter = 0;
        int a= 0;
        for (int i = 0; i<n; i++) {
            if (i > 0) {
                int b = Convert.ToInt32(Console.ReadLine());
                if (a==b) {
                    comparisonCounter++;
                } else if (a!=b) {
                    counter = Math.Max(counter, comparisonCounter);
                    comparisonCounter = 0;
                }
                counter = Math.Max(counter, comparisonCounter);
                a = b;
            } else {
                a = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine(counter);
    }
}