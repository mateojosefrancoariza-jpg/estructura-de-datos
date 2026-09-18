namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes =
 { "gokupetro","vegeta","cesilio"};

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"indice[0]: {estudiantes[i]}");
            }
        }
    }
}
