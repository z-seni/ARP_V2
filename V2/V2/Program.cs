using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{

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
        int[] A = new int[length];

        //fill array
        for (int i = 0; i < length; i++)
        {
            A[i] = int.Parse(array[i]);
            Console.Write(array[i] + ", ");
        }

        int[] D = new int[length];

        for (int k = 0; k < 8; k++)
        {
            for (int i = 0; i < length; i++)
            {
                D[i] = A[i] & 1;
            }
            //sort d
        }


        //Pisanje v izhodno datoteko
        using (StreamWriter writer = new StreamWriter("out.txt"))
        {
            foreach (var item in B)
            {
                writer.Write(item);
                writer.Write(' ');
            }
        }
        
       
    }
}