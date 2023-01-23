using System;
class Program
{
    static void Main()
    {
        string g = " ";
        double lastNum = 0;
        while (g != "q")
        {
            g = Console.ReadLine();
            if (int.TryParse(g, out int t)) 
            {
                Console.WriteLine((char)t);
                lastNum = t; 
            }
            
            else if (double.TryParse(g, out double d))
            {
                if (d==lastNum)
                {
                    break;
                }
                lastNum= d;
            }
        }
    }
}