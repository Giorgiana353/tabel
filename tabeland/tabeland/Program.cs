namespace tabeland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabel de adevar pentru functia SI (AND):");
            Console.WriteLine("|  A  |  B  |  A AND B  |");
            Console.WriteLine("|-----|-----|-----------|");

            for (int a = 0; a <= 1; a++)
            {
                for (int b = 0; b <= 1; b++)
                {
                    bool result = (a == 1) && (b == 1);
                    Console.WriteLine($"|  {a}  |  {b}  |     {result}     |");
                }
            }

            Console.ReadLine();
        }
    }
}