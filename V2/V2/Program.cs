using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        string input = args[1];
        string numbers = File.ReadAllText(input);
        string[] array = numbers.Split(' ');
        int length = array.Length;
        int[] A = new int[length];


        if (args[0] == "0")
        {
            
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
        else if (args[0] == "1")
        {

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
        else
        {
            Console.WriteLine("Napačana zastavica");
        }
    }
}