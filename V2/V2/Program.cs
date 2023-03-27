using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void PrintBinChar(char x){

        for (int k = 0; k < 8; ++k)
        {
            Console.Write((x >> 7-k) & 1);
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
        List<char> A = new List<char>();
        List<char> B = new List<char>();

        //bool bit = (A[i] >> k) & 1;

        //fill array
        for (int i = 0; i < length; i++)
        {
            A.Add((char)(int.Parse(array[i])));
            PrintBinChar(A.ElementAt(i));
        }
        Console.WriteLine();

        B = A;
        bool[] D = new bool[length];

        for (int k = 0; k < 1; k++)
        {
            for (int i = 0; i < length; i++)
            {
                if(((A[i] >> k) & 1) == 1)
                {
                    D[i] = true;
                }
                else if (((A[i] >> k) & 1) == 0)
                {
                    D[i] = false;
                }
            }

            foreach (var item in D)
            {
                if (item) Console.Write("1, ");
                else Console.Write("0, ");
            }

            //sort 
            int[] C = { 0, 0 };
            //Nastavitev C
            for (int i = 0; i < length; i++)
            {
                A[i] = C[(A[i] >> k) & 1]++;
            }
            //Seštevanje v C
            C[1] += C[0];

            //int[] B = new int[length];

            for (int i = length - 1; i >= 0; i--)
            {
                B[--C[A[i] >> k & 1]] = A[i];
            }

            A = B;

            for (int i = 0; i < length; i++)
            {
                //A[i] = D[i];
                Console.Write(A[i] + ", ");
            }
            Console.WriteLine();
        }


        //Pisanje v izhodno datoteko
        //using (StreamWriter writer = new StreamWriter("out.txt"))
        //{
        //    foreach (var item in B)
        //    {
        //        writer.Write(item);
        //        writer.Write(' ');
        //    }
        //}
        
       
    }
}