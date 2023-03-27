using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void PrintBinbyte(byte x){

        for (int k = 0; k < 8; ++k)
        {
            Console.Write((x >> k) & 1);
        }

        Console.Write(" -> " + (int)x);
        
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        string input = "";
        if (args[0] != null)
        {
            input = args[0];
        }
        else
        {
            Console.WriteLine("Napačana zastavica");
        }

        string numbers = File.ReadAllText(input);
        string[] array = numbers.Split(' ');
        int length = array.Length;
        byte[] A = new byte[length];
        byte[] B = new byte[length];

        //fill array
        for (int i = 0; i < length; i++)
        {
            A[i] = (byte)(int.Parse(array[i]));
            B[i] = (byte)(int.Parse(array[i]));
        }

        for (int k = 0; k < 8; ++k)
        {
            //Nastavitev C
            int[] C = { 0, 0 };
            //Štetje ponovitev 0 in 1
            for (int i = 0; i < length; i++)
            {
                C[(A[i] >> k) & 1]++;
            }
            //Seštevanje v C
            C[1] += C[0];
            //Prepis v B v pravem vrstnem redu
            for (int i = length-1; i >= 0; --i)
            {
                //PrintBinbyte(A[i]);
                B[(--C[A[i] >> k & 1])] = A[i];
            }
            //Kopija B v A 
            for (int i = 0; i < length; i++)
            {
                A[i] = B[i];
            }           

        }
        
        //Izpis v konzolo
        //for (int i = 0; i < length; i++)
        //{
        //    Console.Write(A[i] + " ");
        //}

        //Pisanje v izhodno datoteko
        using (StreamWriter writer = new StreamWriter("out.txt"))
        {
            foreach (var item in A)
            {
                writer.Write(item);
                writer.Write(' ');
            }
        }


    }
}