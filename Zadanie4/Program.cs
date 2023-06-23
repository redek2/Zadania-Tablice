using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int rOZMIAR, i, min, max;

        rOZMIAR = 10;
        int[] tab = new int[rOZMIAR];

        for (i = 0; i <= rOZMIAR - 1; i++)
        {
            tab[i] = random.Next(100);
        }

        Console.WriteLine("Tablica przed sortowaniem:");
        for (i = 0; i <= rOZMIAR - 1; i++)
        {
            Console.WriteLine(tab[i]);
        }

        sortowanieWst(tab);

        Console.WriteLine("\nTablica po sortowaniu:");
        for (i = 0; i <= rOZMIAR - 1; i++)
        {
            Console.WriteLine(tab[i]);
        }

        min = tab[0];
        max = tab[0];

        for (i = 0; i <= rOZMIAR - 1; i++)
        {
            if (tab[i] < min)
                min = tab[i];
        }

        Console.WriteLine("\nNajmniejszy element tablicy to " + min);

        for (i = 0; i <= rOZMIAR - 1; i++)
        {
            if (tab[i] > max)
                max = tab[i];
        }

        Console.WriteLine("\nNajwiększy element tablicy to " + max);
    }

    public static void sortowanieWst(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }

            array[j + 1] = key;
        }
    }
}
