namespace szallodafoglalo
{
    internal class Program
    {
        static void szallodafeladat()
        {
            //2 személy szobánként max
            int[] szallodaszobak = new int[12];
            Console.WriteLine("Kérem adja meg hány meber szeretné kifoglalni a szobát");
            int bekeres = Convert.ToInt32(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            szallodafeladat(); 
        }
    }
}
