namespace szallodafoglalo
{
    internal class Program
    {
        static void szallodafeladat()
        {
            //2 személy szobánként max
            int[] szallodaszobak = new int[12];
            Console.Write("Kérem adja meg hány meber szeretné kifoglalni a szobát");
            int bekeres = Convert.ToInt32(Console.ReadLine());
            int sorszam = 0;
            while (sorszam < 11)
            {
                if (bekeres > 1)
                {
                    szallodaszobak[sorszam] = 2;
                    bekeres -= 2;

                }
                else if (bekeres == 1)
                {
                    szallodaszobak[sorszam] = 1;
                    bekeres -= 1;

                }
                else
                {
                    szallodaszobak[sorszam] = 0;
                }
            }
            for (int i = 0; i < szallodaszobak.Length; i++)
            {
                
            }

        }
        static void Main(string[] args)
        {
            szallodafeladat();
            
        }
    }
}
