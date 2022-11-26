using System;
class Program
{
    static void Main()
    {
        string[] words = new string[] { "jojj", "tytrr", "kk", "kok", "op" };


        for (byte i = 0; i < words.Length; i++)
        {

            if (words[i].Length <= 3)
            {
                // Console.Write("[");
                System.Console.Write($"['{words[i]}']", words[i]);

                // Console.Write("]");
            }

        }

    }

}