using System.Diagnostics;

namespace szallodafoglalo
{
    internal class Program
    {
        static void szallodafeladat()
        {
            //2 személy szobánként max

            //menüpontok
            static void fobekeres()
            {
                int[] szallodaszobak = new int[12];
                Console.Write("Kérem adja meg hány ember szeretné kifoglalni a szállodát: ");
                int bekeres = Convert.ToInt32(Console.ReadLine());
                int sorszam = 0;
                
                while (sorszam < 12)
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
                    sorszam++;
                }
                for (int i = 0; i < szallodaszobak.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. szoba: {szallodaszobak[i]} fő");
                }






            }
            string regisztralt_nev = "";
            string regisztralt_jelszo = "";
            
            bool bejelentkezett = false;
            Console.WriteLine("Szállodafoglaló program");
            
            bool kilepes_notrue = true;
            while (kilepes_notrue)
            {
                Console.WriteLine("1 : regisztráció a szálloda weboldalára: ");
                Console.WriteLine("2 : bejelentkezés a szálloda weboldalára: ");
                Console.WriteLine("3 : szobák lefoglalasa szemelyek szamara");
                Console.WriteLine("4 : kilépés");
                int bekert_menupont = Convert.ToInt32(Console.ReadLine());



                switch (bekert_menupont)
                {
                    case 1:
                        Console.Write("Kérem adja meg a nevét: ");

                        regisztralt_nev = Console.ReadLine();



                        Console.Write("Kérem találjon ki egy jelszót: ");

                        regisztralt_jelszo = Console.ReadLine();

                        break;

                    case 2:
                        

                        Console.Write("kérem adja meg a nevet amivel regisztált: ");
                        string bekertadat = Console.ReadLine();
                        Console.Write("kérem adja meg a jelszót amivel regisztált: ");
                        string bekertadat2 = Console.ReadLine();

                        if (bekertadat == regisztralt_nev && bekertadat2 == regisztralt_jelszo)
                        {
                            bejelentkezett = true;
                            Console.WriteLine("Sikeres bejelentkezés!");
                        }
                        else
                        {
                            Console.WriteLine("Sikertelen bejelentkezés");
                        }


                        break;


                    case 3:
                        if (regisztralt_nev != "" && regisztralt_jelszo != "" && bejelentkezett)
                        {
                            fobekeres();
                        }
                        else
                        {
                            Console.WriteLine("hiba! nem jelentkeztél be vagy még nem regisztáltál vagy nem adtál meg semmit!");
                        }

                        break;

                    case 4:
                        kilepes_notrue = false;
                        break;


                    default: Console.WriteLine("Rossz opciót adtál meg"); break;

                }
            }
            
            
        }
        static void Main(string[] args)
        {
            szallodafeladat();
            
        }
    }
}
