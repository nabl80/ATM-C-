using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bankomatas4
{
    class Program
    {

        static string pin = "1234";
        static decimal saskaitosLikutis = 1000;
        static List<string> operacijos = new List<string>();
        static decimal limitas = 700;
        static decimal kursas = 3.45M;
        static Dictionary<string, string> ZodynasLt_En = new Dictionary<string, string>();
        static Dictionary<string, string> ZodynasLt_Ru = new Dictionary<string, string>();
        static int kalbosPasirinkimas = 1;
        static string message = "Klaida. Neteisingai suvesta informacija";
        static string pathOperacijos = @"C:\Users\Eugenijus\Desktop\Mano\VCS2021\C#\operacijos.txt";
        public static List<Tranzakcija> TranzakcijuSarasas = new List<Tranzakcija>();
        
        static void Main(string[] args)
        {
            FrazesEng();
            FrazesRus();
            Kalba();
            Console.ReadLine();
        }
        static void Kalba()
        {
            Console.WriteLine("Pasirinkite kalba: \n 1 - LIETUVIŠKAI \n 2 - ENGLISH \n 3 - RUSSIAN");
            kalbosPasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (kalbosPasirinkimas)
            {
                case 1:
                    Pause();
                    Console.WriteLine("Laba diena");
                    Pause();
                    Clean();
                    VestiPin();
                    break;



                case 2:
                    Pause();
                    Console.WriteLine(Vertejas("Laba diena"));
                    Pause();
                    Clean();
                    VestiPin();
                    break;

                case 3:
                    Pause();
                    Console.WriteLine(Vertejas("Laba diena"));
                    Pause();
                    Clean();
                    VestiPin();
                    break;

                default:
                    Pause();
                    Console.WriteLine("Klaida. Pradekite is naujo");
                    Pause();
                    Clean();
                    Kalba();
                    break;

            }

            Console.Clear();
        }
        static void VestiPin()
        {

            if (kalbosPasirinkimas == 1)
            {
                VestiPinVertejas();
            }
            if (kalbosPasirinkimas == 2)
            {
                VestiPinVertejas();
            }
            if (kalbosPasirinkimas == 3)
            {
                VestiPinVertejas();
            }
        }
        static void VestiPinVertejas()
        {
            Clean();
            int bandymas = 2;
            int counter = 1;
            Console.WriteLine(Vertejas("Iveskite PIN koda"));
            string suvestasPin = Console.ReadLine();

            while (suvestasPin != pin)
            {
                Console.WriteLine(Vertejas("Neteisingas PIN"));
                Pause();
                if (counter == 3)
                {
                    Console.WriteLine(Vertejas("Saskaita uzblokuota. Kreipkites i savo banka"));
                    Pause();
                    Pause();
                    Pause();
                    Environment.Exit(0);

                    break;
                }
                Console.WriteLine(Vertejas("Bandykite dar karta"));
                Pause();
                Console.WriteLine(Vertejas("Liko bandymu: ") + bandymas);
                Pause();

                suvestasPin = Console.ReadLine();
                bandymas--;
                counter++;
            }

            if (suvestasPin == pin)
            {
                Pause();
                Console.WriteLine(Vertejas("Teisingas PIN"));
                Pause();
                Clean();
                Meniu();


            }

        }
        static void Meniu()
        {
            try
            {
                if (kalbosPasirinkimas == 1)
                {
                    Clean();
                    Pause();
                    Console.WriteLine("Pasirinkite norima veiksma: \n " +
                        "1 - Keisti kalba \n " +
                        "2 - Keisti PIN koda \n " +
                        "3 - Saskaitos likutis \n " +
                        "4 - Saskaitos israsas \n " +
                        "5 - Inesti pinigus \n " +
                        "6 - Pasiimti pinigus \n " +
                        "7 - Atlikti pavedima \n " +
                        "8 - Skaityti faila \n " +
                        "9 - Greita operaciju perziura \n " +
                        "0 - Baigti darba");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Kalba();
                            Pause();
                            Clean();
                            break;
                        case 2:
                            ValiduotiPin();
                            Pause();
                            Clean();
                            break;
                        case 3:
                            Clean();
                            Likutis();
                            Pause();
                            Clean();
                            break;
                        case 4:
                            GeneruotiIsrasa();
                            Pause();
                            Clean();
                            break;
                        case 5:
                            InestiPinigus();
                            Pause();
                            Clean();
                            break;
                        case 6:
                            IsimtiPinigus();
                            Pause();
                            Clean();
                            break;
                        case 7:
                            AtliktiPavedima();
                            Pause();
                            Clean();
                            break;
                        case 8:
                            Pause();
                            Clean();
                            SkaitytiTxt();
                            break;
                        case 9:
                            Clean();
                            ZiuretiGlobal();
                            break;
                        case 0:
                            UzbaigtiDarba();
                            break;
                        default:
                            Console.WriteLine("Klaida. Pradekite is naujo");
                            Pause();
                            VestiPin();
                            Pause();
                            Clean();
                            break;
                    }
                }
                if (kalbosPasirinkimas == 2)
                {
                    Clean();
                    Pause();
                    Console.WriteLine("Choose an option: \n " +
                        "1 - Change language \n " +
                        "2 - Change PIN \n " +
                        "3 - Balance \n " +
                        "4 - List of operations \n " +
                        "5 - Add money to your account \n " +
                        "6 - Withdraw cash \n " +
                        "7 - Money transfer \n " +
                        "8 - To read file \n " +
                        "9 - Brief overview \n " +
                        "0 - Finish");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Kalba();
                            Pause();
                            Clean();
                            break;
                        case 2:
                            ValiduotiPin();
                            Pause();
                            Clean();
                            break;
                        case 3:
                            Clean();
                            Likutis();
                            Pause();
                            Clean();
                            break;
                        case 4:
                            GeneruotiIsrasa();
                            Pause();
                            Clean();
                            break;
                        case 5:
                            InestiPinigus();
                            Pause();
                            Clean();
                            break;
                        case 6:
                            IsimtiPinigus();
                            Pause();
                            Clean();
                            break;
                        case 7:
                            AtliktiPavedima();
                            Pause();
                            Clean();
                            break;
                        case 8:
                            Pause();
                            Clean();
                            SkaitytiTxt();
                            break;
                        case 9:
                            Clean();
                            ZiuretiGlobal();
                            break;
                        case 0:
                            UzbaigtiDarba();
                            break;
                        default:
                            Console.WriteLine(Vertejas("Klaida. Pradekite is naujo"));
                            Pause();
                            VestiPin();
                            Pause();
                            Clean();
                            break;
                    }
                }
                if (kalbosPasirinkimas == 3)
                {
                    Clean();
                    Pause();
                    Console.WriteLine("Выберите: \n " +
                        "1 - Смена языка \n " +
                        "2 - Смена PIN \n " +
                        "3 - Баланс \n " +
                        "4 - Список операций \n " +
                        "5 - Пополнение счета \n " +
                        "6 - Снятие средств \n " +
                        "7 - Денежный перевод \n " +
                        "8 - Читать файл \n " +
                        "9 - Быстрый просмотр операций \n " +
                        "0 - Окончание работы");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Kalba();
                            Pause();
                            Clean();
                            break;
                        case 2:
                            ValiduotiPin();
                            Pause();
                            Clean();
                            break;
                        case 3:
                            Clean();
                            Likutis();
                            Pause();
                            Clean();
                            break;
                        case 4:
                            GeneruotiIsrasa();
                            Pause();
                            Clean();
                            break;
                        case 5:
                            InestiPinigus();
                            Pause();
                            Clean();
                            break;
                        case 6:
                            IsimtiPinigus();
                            Pause();
                            Clean();
                            break;
                        case 7:
                            AtliktiPavedima();
                            Pause();
                            Clean();
                            break;
                        case 8:
                            Pause();
                            Clean();
                            SkaitytiTxt();
                            break;
                        case 9:
                            Clean();
                            ZiuretiGlobal();
                            break;
                        case 0:
                            UzbaigtiDarba();
                            break;
                        default:
                            Console.WriteLine(Vertejas("Klaida. Pradekite is naujo"));
                            Pause();
                            VestiPin();
                            Pause();
                            Clean();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Exception();
            }
        }
        static void ValiduotiPin()
        {
            if (kalbosPasirinkimas == 1)
            {
                ValiduotiPinVertejas();
            }
            if (kalbosPasirinkimas == 2)
            {
                ValiduotiPinVertejas();
            }
            if (kalbosPasirinkimas == 3)
            {
                ValiduotiPinVertejas();
            }
        }
        static void ValiduotiPinVertejas()
        {
            Pause();
            Console.Clear();
            Console.WriteLine(Vertejas("Iveskite PIN koda"));
            string suvestasPin2 = Console.ReadLine();
            if (suvestasPin2 == pin)
            {
                Console.WriteLine(Vertejas("Teisingas PIN. Palaukite ..."));
                Pause();
                IvestiNaujaPin();
            }
            else
            {
                Console.WriteLine(Vertejas("Klaida. Pradekite is naujo"));
                Pause();
                Kalba();
            }
        }
        static void Clean()
        {
            Console.Clear();
        }
        static void Pause()
        {
            Thread.Sleep(1000);

        }
        static void IsimtiPinigus()
        {
            try
            {
                if (kalbosPasirinkimas == 1)
                {
                    Pause();
                    Clean();
                    Limitas();
                    Console.WriteLine("Pasirinkite valiuta: 1 - EUR, 0- LTL");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Nurodykite suma EUR \n Galimi siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR ");
                        decimal paimamaSuma = Convert.ToDecimal(Console.ReadLine());
                        while (paimamaSuma % 10 != 0)
                        {
                            Console.WriteLine("Bankomatas isduoda tik siu nominalu banknotus: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR");
                            Pause();
                            Pause();
                            Clean();
                            IsimtiPinigus();
                            break;
                        }
                        if (paimamaSuma <= saskaitosLikutis && paimamaSuma <= limitas)
                        {
                            Console.WriteLine("Prasome palaukti...");
                            Pause();
                            Console.WriteLine("Paimkite pinigus");
                            Pause();
                            Clean();
                            operacijos.Add(paimamaSuma + " EUR nuskaiciuota nuo saskaitos. " + DateTime.Now);


                            Tranzakcija trn = new Tranzakcija();
                            trn.Suma = paimamaSuma;
                            trn.Valiuta = "EUR";
                            trn.MokėjimoPaskirtis = "Isgryninimas";
                            trn.Data = DateTime.Now;
                            trn.Informacija();
                            TranzakcijuSarasas.Add(trn);



                            Console.WriteLine($"Nuo saskaitos numta {paimamaSuma} EUR");
                            saskaitosLikutis = saskaitosLikutis - paimamaSuma;
                            limitas = limitas - paimamaSuma;
                            Pause();
                            Pause();
                            Clean();
                            Likutis();
                            Pause();
                            Pause();
                            TolimesnisVeiksmas();
                        }
                        else if (paimamaSuma > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }
                        else
                        {
                            LesuTrukumas();
                            Pause();
                            Clean();
                            TolimesnisVeiksmas();
                        }
                    }
                    else if (choice == 0)
                    {
                        Console.WriteLine("Nurodykite suma LTL, kuria norite pasiimti \n Galimi siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL ");
                        decimal paimamaSuma = Convert.ToDecimal(Console.ReadLine());
                        decimal paimamaSumaEur = Math.Round(paimamaSuma / kursas, 2);
                        while (paimamaSuma % 50 != 0)
                        {
                            Console.WriteLine("Bankomatas isduoda tik siu nominalu banknotus: \n 50 LTL \n 100 LTL \n 200 LTL");
                            Pause();
                            Pause();
                            Clean();
                            IsimtiPinigus();
                            break;
                        }
                        if (paimamaSumaEur <= saskaitosLikutis && paimamaSumaEur <= limitas)
                        {
                            Console.WriteLine("Prasome palaukti...");
                            Pause();
                            Console.WriteLine("Paimkite pinigus");
                            Pause();
                            Clean();
                            operacijos.Add(paimamaSuma + " LTL " + "(" + paimamaSumaEur + " EUR) nuskaiciuota nuo saskaitos. " + DateTime.Now);

                            Tranzakcija trn = new Tranzakcija();
                            trn.Suma = paimamaSuma;
                            trn.Valiuta = "LTL";
                            trn.MokėjimoPaskirtis = "Isgryninimas";
                            trn.Data = DateTime.Now;
                            trn.Informacija();
                            TranzakcijuSarasas.Add(trn);

                            Console.WriteLine($"Nuo saskaitos nuimta {paimamaSuma} LTL ({paimamaSumaEur} EUR)");
                            saskaitosLikutis = saskaitosLikutis - paimamaSumaEur;
                            limitas = limitas - paimamaSumaEur;
                            Pause();
                            Pause();
                            Clean();
                            Likutis();
                            Pause();
                            Pause();
                            TolimesnisVeiksmas();
                        }
                        else if (paimamaSuma > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }
                        else
                        {
                            LesuTrukumas();
                            Pause();
                            Clean();
                            TolimesnisVeiksmas();

                        }


                    }
                    else
                    {
                        Pause();
                        Clean();
                        Console.WriteLine("Klaida. Pradekite is pradziu");
                        Pause();
                        Meniu();

                    }
                }
                if (kalbosPasirinkimas == 2)
                {
                    Pause();
                    Clean();
                    Limitas();
                    Console.WriteLine(Vertejas("Pasirinkite valiuta: 1 - EUR, 0- LTL"));
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine(Vertejas("Nurodykite suma EUR \n Galimi siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR "));
                        decimal paimamaSuma = Convert.ToDecimal(Console.ReadLine());
                        while (paimamaSuma % 10 != 0)
                        {
                            Console.WriteLine(Vertejas("Klaida. Galimi tik siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR"));
                            Pause();
                            Pause();
                            Clean();
                            IsimtiPinigus();
                            break;
                        }
                        if (paimamaSuma <= saskaitosLikutis && paimamaSuma <= limitas)
                        {
                            Console.WriteLine(Vertejas("Prasome palaukti..."));
                            Pause();
                            Console.WriteLine(Vertejas("Paimkite pinigus"));
                            Pause();
                            Clean();

                            Tranzakcija trn = new Tranzakcija();
                            trn.Suma = paimamaSuma;
                            trn.Valiuta = "EUR";
                            trn.MokėjimoPaskirtis = "Cash withdrawal";
                            trn.Data = DateTime.Now;
                            trn.InformacijaEN();
                            TranzakcijuSarasas.Add(trn);

                            operacijos.Add(paimamaSuma + Vertejas(" EUR nuskaiciuota nuo saskaitos. ") + DateTime.Now);
                            Console.WriteLine(paimamaSuma + Vertejas(" EUR nuskaiciuota nuo saskaitos. "));
                            saskaitosLikutis = saskaitosLikutis - paimamaSuma;
                            limitas = limitas - paimamaSuma;
                            Pause();
                            Pause();
                            Clean();
                            Likutis();
                            Pause();
                            Pause();
                            TolimesnisVeiksmas();
                        }
                        else if (paimamaSuma > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }
                        else
                        {
                            LesuTrukumas();
                            Pause();
                            Clean();
                            TolimesnisVeiksmas();
                        }
                    }
                    else if (choice == 0)
                    {
                        Console.WriteLine(Vertejas("Nurodykite suma LTL \n Galimi siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL "));
                        decimal paimamaSuma = Convert.ToDecimal(Console.ReadLine());
                        decimal paimamaSumaEur = Math.Round(paimamaSuma / kursas, 2);
                        while (paimamaSuma % 50 != 0)
                        {
                            Console.WriteLine(Vertejas("Klaida. Galimi tik siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL"));
                            Pause();
                            Pause();
                            Clean();
                            IsimtiPinigus();
                            break;
                        }
                        if (paimamaSumaEur <= saskaitosLikutis && paimamaSumaEur <= limitas)
                        {
                            Console.WriteLine(Vertejas("Prasome palaukti..."));
                            Pause();
                            Console.WriteLine(Vertejas("Paimkite pinigus"));
                            Pause();
                            Clean();
                            operacijos.Add(paimamaSuma + " LTL " + "/" + paimamaSumaEur + Vertejas(" EUR nuskaiciuota nuo saskaitos. ") + DateTime.Now);

                            Tranzakcija trn = new Tranzakcija();
                            trn.Suma = paimamaSuma;
                            trn.Valiuta = "LTL";
                            trn.MokėjimoPaskirtis = "Cash withdrawal";
                            trn.Data = DateTime.Now;
                            trn.InformacijaEN();
                            TranzakcijuSarasas.Add(trn);

                            Console.WriteLine(paimamaSuma + " LTL /" + paimamaSumaEur + Vertejas(" EUR nuskaiciuota nuo saskaitos. "));
                            saskaitosLikutis = saskaitosLikutis - paimamaSumaEur;
                            limitas = limitas - paimamaSumaEur;
                            Pause();
                            Pause();
                            Clean();
                            Likutis();
                            Pause();
                            Pause();
                            TolimesnisVeiksmas();
                        }
                        else if (paimamaSuma > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }
                        else
                        {
                            LesuTrukumas();
                            Pause();
                            Clean();
                            TolimesnisVeiksmas();

                        }


                    }
                    else
                    {
                        Pause();
                        Clean();
                        Console.WriteLine(Vertejas("Klaida. Pradekite is naujo"));
                        Pause();
                        Meniu();

                    }
                }
                if (kalbosPasirinkimas == 3)
                {
                    Pause();
                    Clean();
                    Limitas();
                    Console.WriteLine(Vertejas("Pasirinkite valiuta: 1 - EUR, 0- LTL"));
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine(Vertejas("Nurodykite suma EUR \n Galimi siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR "));
                        decimal paimamaSuma = Convert.ToDecimal(Console.ReadLine());
                        while (paimamaSuma % 10 != 0)
                        {
                            Console.WriteLine(Vertejas("Klaida. Galimi tik siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR"));
                            Pause();
                            Pause();
                            Clean();
                            IsimtiPinigus();
                            break;
                        }

                        if (paimamaSuma <= saskaitosLikutis && paimamaSuma <= limitas)
                        {
                            Console.WriteLine(Vertejas("Prasome palaukti..."));
                            Pause();
                            Console.WriteLine(Vertejas("Paimkite pinigus"));
                            Pause();
                            Clean();

                            Tranzakcija trn = new Tranzakcija();
                            trn.Suma = paimamaSuma;
                            trn.Valiuta = "EUR";
                            trn.MokėjimoPaskirtis = "Снятие наличных";
                            trn.Data = DateTime.Now;
                            trn.InformacijaRU();
                            TranzakcijuSarasas.Add(trn);

                            operacijos.Add(paimamaSuma + Vertejas(" EUR nuskaiciuota nuo saskaitos. ") + DateTime.Now);
                            Console.WriteLine(paimamaSuma + Vertejas(" EUR nuskaiciuota nuo saskaitos. "));
                            saskaitosLikutis = saskaitosLikutis - paimamaSuma;
                            limitas = limitas - paimamaSuma;
                            Pause();
                            Pause();
                            Clean();
                            Likutis();
                            Pause();
                            Pause();
                            TolimesnisVeiksmas();
                        }

                        else if (paimamaSuma > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }

                        else
                        {
                            LesuTrukumas();
                            Pause();
                            Clean();
                            TolimesnisVeiksmas();
                        }
                    }
                    else if (choice == 0)
                    {
                        Console.WriteLine(Vertejas("Nurodykite suma LTL \n Galimi siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL "));
                        decimal paimamaSuma = Convert.ToDecimal(Console.ReadLine());
                        decimal paimamaSumaEur = Math.Round(paimamaSuma / kursas, 2);
                        while (paimamaSuma % 50 != 0)
                        {
                            Console.WriteLine(Vertejas("Klaida. Galimi tik siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL"));
                            Pause();
                            Pause();
                            Clean();
                            IsimtiPinigus();
                            break;
                        }
                        if (paimamaSumaEur <= saskaitosLikutis && paimamaSumaEur <= limitas)
                        {
                            Console.WriteLine(Vertejas("Prasome palaukti..."));
                            Pause();
                            Console.WriteLine(Vertejas("Paimkite pinigus"));
                            Pause();
                            Clean();
                            operacijos.Add(paimamaSuma + " LTL " + "/" + paimamaSumaEur + Vertejas(" EUR nuskaiciuota nuo saskaitos. ") + DateTime.Now);
                            Console.WriteLine(paimamaSuma + " LTL /" + paimamaSumaEur + Vertejas(" EUR nuskaiciuota nuo saskaitos. "));
                            Tranzakcija trn = new Tranzakcija();
                            trn.Suma = paimamaSuma;
                            trn.Valiuta = "LTL";
                            trn.MokėjimoPaskirtis = "Снятие наличных";
                            trn.Data = DateTime.Now;
                            trn.InformacijaRU();
                            TranzakcijuSarasas.Add(trn);
                            saskaitosLikutis = saskaitosLikutis - paimamaSumaEur;
                            limitas = limitas - paimamaSumaEur;
                            Pause();
                            Pause();
                            Clean();
                            Likutis();
                            Pause();
                            Pause();
                            TolimesnisVeiksmas();
                        }
                        else if (paimamaSuma > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }
                        else
                        {
                            LesuTrukumas();
                            Pause();
                            Clean();
                            TolimesnisVeiksmas();

                        }


                    }
                    else
                    {
                        Pause();
                        Clean();
                        Console.WriteLine(Vertejas("Klaida. Pradekite is naujo"));
                        Pause();
                        Meniu();

                    }
                }
            }
            catch (Exception)
            {
                Exception();
            }
        }
        static void InestiPinigus()
        {
            try
            {
                if (kalbosPasirinkimas == 1)
                {
                    Pause();
                    Clean();

                    Console.WriteLine("Pasirinkite valiuta: \n 1 - EUR \n 0 - LTL");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Idekite pinigus i anga");

                    if (choice == 1)
                    {
                        Pause();
                        Console.WriteLine("Galima naudoti siuos banknotus: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR ");
                        decimal inesamaSuma = Convert.ToInt32(Console.ReadLine());
                        Pause();
                        while (inesamaSuma % 10 != 0)
                        {
                            Console.WriteLine("Klaida. Galima naudoti siuos banknotus: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR");
                            Pause();
                            Pause();
                            Pause();
                            Clean();
                            InestiPinigus();
                            break;
                        }
                        operacijos.Add(inesamaSuma + " EUR inesta i saskaita. " + DateTime.Now);

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = inesamaSuma;
                        trn.Valiuta = "EUR";
                        trn.MokėjimoPaskirtis = "Saskaitos papildymas";
                        trn.Data = DateTime.Now;
                        trn.Informacija();
                        TranzakcijuSarasas.Add(trn);

                        Console.WriteLine("Inesama suma lygi " + inesamaSuma + " EUR");
                        saskaitosLikutis = saskaitosLikutis + inesamaSuma;
                        Pause();
                        Pause();
                        Clean();
                        Likutis();
                        Pause();
                        Pause();
                        TolimesnisVeiksmas();
                    }
                    else if (choice == 0)
                    {
                        Pause();
                        Console.WriteLine("Galima naudoti siuos banknotus:  \n 50 LTL \n 100 LTL \n 200 LTL ");
                        decimal inesamaSuma = Convert.ToInt32(Console.ReadLine());
                        decimal inesamaSumaEur = Math.Round(inesamaSuma / kursas, 2);
                        Pause();
                        while (inesamaSuma % 50 != 0)
                        {
                            Console.WriteLine("Klaida. Galima naudoti siuos banknotus: \n 50 LTL \n 100 LTL \n 200 LTL");
                            Pause();
                            Pause();
                            Pause();
                            Clean();
                            InestiPinigus();
                            break;
                        }

                        operacijos.Add(inesamaSuma + " LTL " + "(" + inesamaSumaEur + " EUR) inesta i saskaita. " + DateTime.Now);

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = inesamaSuma;
                        trn.Valiuta = "LTL";
                        trn.MokėjimoPaskirtis = "Saskaitos papildymas";
                        trn.Data = DateTime.Now;
                        trn.Informacija();
                        TranzakcijuSarasas.Add(trn);

                        Console.WriteLine("Inesama suma lygi " + inesamaSuma + " LTL (" + inesamaSumaEur + " EUR)");
                        saskaitosLikutis = saskaitosLikutis + inesamaSumaEur;
                        Pause();
                        Pause();
                        Clean();
                        Likutis();
                        Pause();
                        Pause();
                        TolimesnisVeiksmas();
                    }
                    else
                    {
                        Pause();
                        Clean();
                        Console.WriteLine("Klaida. Pradekite is pradziu");
                        Pause();
                        Pause();
                        Meniu();
                    }

                }
                if (kalbosPasirinkimas == 2)
                {
                    Pause();
                    Clean();

                    Console.WriteLine(Vertejas("Pasirinkite valiuta: 1 - EUR, 0- LTL"));
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Vertejas("Idekite pinigus i anga"));

                    if (choice == 1)
                    {
                        Pause();
                        Console.WriteLine(Vertejas("Galimi tik siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR "));
                        decimal inesamaSuma = Convert.ToInt32(Console.ReadLine());
                        Pause();
                        while (inesamaSuma % 10 != 0)
                        {
                            Console.WriteLine(Vertejas("Klaida. Galimi tik siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR"));
                            Pause();
                            Pause();
                            Pause();
                            Clean();
                            InestiPinigus();
                            break;
                        }
                        operacijos.Add(inesamaSuma + Vertejas(" EUR inesta i saskaita. ") + DateTime.Now);

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = inesamaSuma;
                        trn.Valiuta = "EUR";
                        trn.MokėjimoPaskirtis = "Cash into account";
                        trn.Data = DateTime.Now;
                        trn.InformacijaEN();
                        TranzakcijuSarasas.Add(trn);

                        Console.WriteLine(Vertejas("Inesama suma lygi ") + inesamaSuma + " EUR");
                        saskaitosLikutis = saskaitosLikutis + inesamaSuma;
                        Pause();
                        Pause();
                        Clean();
                        Likutis();
                        Pause();
                        Pause();
                        TolimesnisVeiksmas();
                    }
                    else if (choice == 0)
                    {
                        Pause();
                        Console.WriteLine(Vertejas("Galimi tik siu nominalu banknotai:  \n 50 LTL \n 100 LTL \n 200 LTL "));
                        decimal inesamaSuma = Convert.ToInt32(Console.ReadLine());
                        decimal inesamaSumaEur = Math.Round(inesamaSuma / kursas, 2);
                        Pause();
                        while (inesamaSuma % 50 != 0)
                        {
                            Console.WriteLine(Vertejas("Klaida. Galimi tik siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL"));
                            Pause();
                            Pause();
                            Pause();
                            Clean();
                            InestiPinigus();
                            break;
                        }


                        operacijos.Add(inesamaSuma + " LTL " + "/" + inesamaSumaEur + Vertejas(" EUR inesta i saskaita. ") + DateTime.Now);

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = inesamaSuma;
                        trn.Valiuta = "LTL";
                        trn.MokėjimoPaskirtis = "Cash into account";
                        trn.Data = DateTime.Now;
                        trn.InformacijaEN();
                        TranzakcijuSarasas.Add(trn);

                        Console.WriteLine(Vertejas("Inesama suma lygi ") + inesamaSuma + " LTL (" + inesamaSumaEur + " EUR)");
                        saskaitosLikutis = saskaitosLikutis + inesamaSumaEur;
                        Pause();
                        Pause();
                        Clean();
                        Likutis();
                        Pause();
                        Pause();
                        TolimesnisVeiksmas();
                    }
                    else
                    {
                        Clean();
                        Pause();
                        //Clean();
                        Console.WriteLine(Vertejas("Klaida. Pradekite is naujo"));
                        Pause();
                        Pause();
                        Meniu();
                    }

                }
                if (kalbosPasirinkimas == 3)
                {
                    Pause();
                    Clean();

                    Console.WriteLine(Vertejas("Pasirinkite valiuta: 1 - EUR, 0- LTL"));
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Vertejas("Idekite pinigus i anga"));

                    if (choice == 1)
                    {
                        Pause();
                        Console.WriteLine(Vertejas("Galimi tik siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR "));
                        decimal inesamaSuma = Convert.ToInt32(Console.ReadLine());
                        Pause();
                        while (inesamaSuma % 10 != 0)
                        {
                            Console.WriteLine(Vertejas("Klaida. Galimi tik siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR"));
                            Pause();
                            Pause();
                            Pause();
                            Clean();
                            InestiPinigus();
                            break;
                        }
                        operacijos.Add(inesamaSuma + Vertejas(" EUR inesta i saskaita. ") + DateTime.Now);

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = inesamaSuma;
                        trn.Valiuta = "EUR";
                        trn.MokėjimoPaskirtis = "Пополнение счета";
                        trn.Data = DateTime.Now;
                        trn.InformacijaRU();
                        TranzakcijuSarasas.Add(trn);

                        Console.WriteLine(Vertejas("Inesama suma lygi ") + inesamaSuma + " EUR");
                        saskaitosLikutis = saskaitosLikutis + inesamaSuma;
                        Pause();
                        Pause();
                        Clean();
                        Likutis();
                        Pause();
                        Pause();
                        TolimesnisVeiksmas();
                    }
                    else if (choice == 0)
                    {
                        Pause();
                        Console.WriteLine(Vertejas("Galimi tik siu nominalu banknotai:  \n 50 LTL \n 100 LTL \n 200 LTL "));
                        decimal inesamaSuma = Convert.ToInt32(Console.ReadLine());
                        decimal inesamaSumaEur = Math.Round(inesamaSuma / kursas, 2);
                        Pause();
                        while (inesamaSuma % 50 != 0)
                        {
                            Console.WriteLine(Vertejas("Klaida. Galimi tik siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL"));
                            Pause();
                            Pause();
                            Pause();
                            Clean();
                            InestiPinigus();
                            break;
                        }


                        operacijos.Add(inesamaSuma + " LTL " + "/" + inesamaSumaEur + Vertejas(" EUR inesta i saskaita. ") + DateTime.Now);

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = inesamaSuma;
                        trn.Valiuta = "LTL";
                        trn.MokėjimoPaskirtis = "Пополнение счета";
                        trn.Data = DateTime.Now;
                        trn.InformacijaRU();
                        TranzakcijuSarasas.Add(trn);

                        Console.WriteLine(Vertejas("Inesama suma lygi ") + inesamaSuma + " LTL (" + inesamaSumaEur + " EUR)");
                        saskaitosLikutis = saskaitosLikutis + inesamaSumaEur;
                        Pause();
                        Pause();
                        Clean();
                        Likutis();
                        Pause();
                        Pause();
                        TolimesnisVeiksmas();
                    }
                    else
                    {
                        Clean();
                        Pause();
                        //Clean();
                        Console.WriteLine(Vertejas("Klaida. Pradekite is naujo"));
                        Pause();
                        Pause();
                        Meniu();
                    }

                }
            }
            catch (Exception)
            {
                Exception();
            }
        }
        static void TolimesnisVeiksmas()
        {
            try
            {
                if (kalbosPasirinkimas == 1)
                {
                    TolimesnisVeiksmasVertejas();
                }
                if (kalbosPasirinkimas == 2)
                {
                    TolimesnisVeiksmasVertejas();
                }
                if (kalbosPasirinkimas == 3)
                {
                    TolimesnisVeiksmasVertejas();
                }
            }
            catch (Exception)
            {
                Exception();
            }
        }
        static void TolimesnisVeiksmasVertejas()
        {
            Pause();
            Console.WriteLine(Vertejas("Pasirinkite: \n 1 - Grizti i meniu \n 0 - Uzbaigti darba"));
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != 1)
            {
                UzbaigtiDarba();
            }
            Pause();
            Meniu();
        }
        static void UzbaigtiDarba()
        {
            if (kalbosPasirinkimas == 1)
            {
                UzbaigtiDarbaVertejas();
            }
            if (kalbosPasirinkimas == 2)
            {
                UzbaigtiDarbaVertejas();
            }
            if (kalbosPasirinkimas == 3)
            {
                UzbaigtiDarbaVertejas();
            }
        }
        static void UzbaigtiDarbaVertejas()
        {
            Console.Clear();
            Console.WriteLine(Vertejas("Viso gero. Paimkite savo kortele"));
            Thread.Sleep(1500);
            Environment.Exit(0);
        }
        static void Likutis()
        {
            Pause();
            if (kalbosPasirinkimas == 1)
            {
                LikutisVertejas();
            }
            if (kalbosPasirinkimas == 2)
            {
                LikutisVertejas();
            }
            if (kalbosPasirinkimas == 3)
            {
                LikutisVertejas();
            }

        }
        static void LikutisVertejas()
        {
            decimal saskaitosLikutisLtl = Math.Round(saskaitosLikutis * kursas, 2);
            Pause();
            Console.WriteLine(Vertejas("Jusu likutis: ") + saskaitosLikutis + " EUR (" + saskaitosLikutisLtl + " LTL)");
            IrasasLikutis();
            Pause();
            Limitas();
            Pause();
            TolimesnisVeiksmas();
        }
        static string Vertejas(string frazeLt)
        {
            if (kalbosPasirinkimas == 1)
            {
                return frazeLt;
            }
            else if (kalbosPasirinkimas == 2)
            {

                string frazeEng = ZodynasLt_En[frazeLt];
                return frazeEng;

            }
            else if (kalbosPasirinkimas == 3)
            {
                string frazeRus = ZodynasLt_Ru[frazeLt];
                return frazeRus;
            }
            else
            {
                return frazeLt;

            }
        }
        static void DienosLimitas()
        {
            if (kalbosPasirinkimas == 1)
            {
                Console.WriteLine("Virsijamas dienos limitas");
            }
            if (kalbosPasirinkimas == 2)
            {
                Console.WriteLine(Vertejas("Virsijamas dienos limitas"));
            }
            if (kalbosPasirinkimas == 3)
            {
                Console.WriteLine(Vertejas("Virsijamas dienos limitas"));
            }
        }
        static void LesuTrukumas()
        {
            if (kalbosPasirinkimas == 1)
            {
                Console.WriteLine("Saskaitoje nepakanka lesu");
            }
            if (kalbosPasirinkimas == 2)
            {
                Console.WriteLine(Vertejas("Saskaitoje nepakanka lesu"));
            }
            if (kalbosPasirinkimas == 3)
            {
                Console.WriteLine(Vertejas("Saskaitoje nepakanka lesu"));
            }
        }
        static void Exception()
        {
            if (kalbosPasirinkimas == 1)
            {
                ExceptionVertejas();
            }
            if (kalbosPasirinkimas == 2)
            {
                ExceptionVertejas();
            }
            if (kalbosPasirinkimas == 3)
            {
                ExceptionVertejas();
            }
        }
        static void ExceptionVertejas()
        {
            Clean();
            Console.WriteLine(Vertejas(message));
            Pause();
            Pause();
            Console.WriteLine(Vertejas("Klaida. Pradekite is naujo"));
            Pause();
            Meniu();
        }
        static void Limitas()
        {
            if (kalbosPasirinkimas == 1)
            {
                Console.WriteLine("Dienos limitas: " + limitas + " EUR (" + Math.Round(limitas * kursas, 2) + " LTL)");
            }
            if (kalbosPasirinkimas == 2)
            {
                Console.WriteLine(Vertejas("Dienos limitas: ") + limitas + " EUR (" + Math.Round(limitas * kursas, 2) + " LTL)");
            }
            if (kalbosPasirinkimas == 3)
            {
                Console.WriteLine(Vertejas("Dienos limitas: ") + limitas + " EUR (" + Math.Round(limitas * kursas, 2) + " LTL)");
            }
        }
        static void FrazesEng()
        {
            ZodynasLt_En.Add("Laba diena", "Wellcome");
            ZodynasLt_En.Add("Iveskite PIN koda", "Enter your PIN");
            ZodynasLt_En.Add("Neteisingas PIN", "Wrong PIN");
            ZodynasLt_En.Add("Saskaita uzblokuota. Kreipkites i savo banka", "Your account is blocked. Contact your Bank");
            ZodynasLt_En.Add("Bandykite dar karta", "Type again");
            ZodynasLt_En.Add("Liko bandymu: ", "Attempts left:");
            ZodynasLt_En.Add("Teisingas PIN", "Correct PIN");
            ZodynasLt_En.Add("Klaida. Pradekite is naujo", "Error. Start from the beginning");
            ZodynasLt_En.Add("Teisingas PIN. Palaukite ...", "Correct PIN. Please wait...");
            ZodynasLt_En.Add("Pasirinkite valiuta: 1 - EUR, 0- LTL", "Choose currency: 1 - EUR, 0 - LTL");
            ZodynasLt_En.Add("Nurodykite suma EUR \n Galimi siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR ",
                "Choose amount in EUR \n These banknotes are available: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR ");
            ZodynasLt_En.Add("Klaida. Galimi tik siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR",
                "Error. Only these banknotes are available: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR");
            ZodynasLt_En.Add("Prasome palaukti...", "Please wait...");
            ZodynasLt_En.Add("Paimkite pinigus", "Take your cash");
            ZodynasLt_En.Add(" EUR nuskaiciuota nuo saskaitos. ", " EUR withdrawed from your account. ");
            ZodynasLt_En.Add("Nurodykite suma LTL \n Galimi siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL ",
                "Choose amount in LTL \n These banknotes are available: \n 50 LTL \n 100 LTL \n 200 LTL ");
            ZodynasLt_En.Add("Klaida. Galimi tik siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL",
                "Error. Only these banknotes are available: \n 50 LTL \n 100 LTL \n 200 LTL");
            ZodynasLt_En.Add("nuskaiciuota nuo saskaitos.", "withdrawed from your account. ");
            ZodynasLt_En.Add("Idekite pinigus i anga", "Please insert money into ATM");
            ZodynasLt_En.Add("Galimi tik siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR ",
                "Only these banknotes are available: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR ");
            ZodynasLt_En.Add(" EUR inesta i saskaita. ", " EUR were added to account. ");
            ZodynasLt_En.Add("Inesama suma lygi ", "Added amount is ");
            ZodynasLt_En.Add("Galimi tik siu nominalu banknotai:  \n 50 LTL \n 100 LTL \n 200 LTL ",
                "Only these banknotes are available:  \n 50 LTL \n 100 LTL \n 200 LTL ");
            ZodynasLt_En.Add("Pasirinkite: \n 1 - Grizti i meniu \n 0 - Uzbaigti darba", "Choose an option: \n 1 - Back to Menu \n 0 - Finish");
            ZodynasLt_En.Add("Viso gero. Paimkite savo kortele", "Take your card. Have a good day.");
            ZodynasLt_En.Add("Jusu likutis: ", "Your balance: ");
            ZodynasLt_En.Add("Iveskite nauja PIN. \n min 4 skaiciai, max 6 skaiciai", "Enter new PIN. \n min 4 digits, max 6 digits");
            ZodynasLt_En.Add("PIN kodas gali buti sudarytas tik is skaiciu [0-9]", "PIN can be made from digits [0-9] only");
            ZodynasLt_En.Add("Jusu PIN pakeistas", "Your PIN has been changed");
            ZodynasLt_En.Add("Klaida. PIN kodas neatitinka formato. Ilgis 4-6 skaiciai", "Error. PIN doesn't fit format. Length: 4-6 digits");
            ZodynasLt_En.Add("Gavejas: ", "Receiver: ");
            ZodynasLt_En.Add("Gavejo saskaitos numeris: ", "Receiver's account Nr.: ");
            ZodynasLt_En.Add("Mokejimo paskirtis: ", "Payment purpose: ");
            ZodynasLt_En.Add("Suma: ", "Sum: ");
            ZodynasLt_En.Add(" 1 - Pavedimas EUR \n 0 - Pavedimas LTL", " 1 - Payment in EUR \n 0 - Payment in LTL");
            ZodynasLt_En.Add("Virsijamas dienos limitas", "Daily limit was reached");
            ZodynasLt_En.Add("Operacija sekmingai ivykdyta", "Payment executed");
            ZodynasLt_En.Add("Saskaitoje nepakanka lesu", "Insufficient funds");
            ZodynasLt_En.Add("Klaida. Neteisingai suvesta informacija", "Error. Wrong input");
            ZodynasLt_En.Add("apmoketa ", "paid ");
            ZodynasLt_En.Add("Dienos limitas: ", "Daily limit left: ");
            ZodynasLt_En.Add("Klaida. Neteisingai ivesta suma [0.00]", "Error. Wrong sum [0.00]");
            ZodynasLt_En.Add("Naujas Pin: ", "New Pin: ");
            ZodynasLt_En.Add("Likutis: ", "Balance: ");

        }
        static void FrazesRus()
        {
            ZodynasLt_Ru.Add("Laba diena", "Шалом!");
            ZodynasLt_Ru.Add("Iveskite PIN koda", "Введите PIN");
            ZodynasLt_Ru.Add("Neteisingas PIN", "Неверный PIN");
            ZodynasLt_Ru.Add("Saskaita uzblokuota. Kreipkites i savo banka", "Ваш счет заблокирован. Обратитесь в банк");
            ZodynasLt_Ru.Add("Bandykite dar karta", "Повторите еще раз");
            ZodynasLt_Ru.Add("Liko bandymu: ", "Осталось попыток:");
            ZodynasLt_Ru.Add("Teisingas PIN", "Правильный PIN");
            ZodynasLt_Ru.Add("Klaida. Pradekite is naujo", "Ошибка. Начните сначала");
            ZodynasLt_Ru.Add("Teisingas PIN. Palaukite ...", "Правильный PIN. Подождите...");
            ZodynasLt_Ru.Add("Pasirinkite valiuta: 1 - EUR, 0- LTL", "Выберите валюту: 1 - EUR, 0 - LTL");
            ZodynasLt_Ru.Add("Nurodykite suma EUR \n Galimi siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR ",
                "Наберите сумму в EUR \n Возможны банкноты номиналом: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR ");
            ZodynasLt_Ru.Add("Klaida. Galimi tik siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR",
                "Ошибка. Возможны банкноты номиналом: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR");
            ZodynasLt_Ru.Add("Prasome palaukti...", "Пожалуйста, подождите...");
            ZodynasLt_Ru.Add("Paimkite pinigus", "Возьмите деньги");
            ZodynasLt_Ru.Add(" EUR nuskaiciuota nuo saskaitos. ", " EUR снято со счета. ");
            ZodynasLt_Ru.Add("Nurodykite suma LTL \n Galimi siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL ",
                "Выберите сумму в LTL \n Возможны банкноты номиналом: \n 50 LTL \n 100 LTL \n 200 LTL ");
            ZodynasLt_Ru.Add("Klaida. Galimi tik siu nominalu banknotai: \n 50 LTL \n 100 LTL \n 200 LTL",
                "Ошибка. Возможны банкноты номиналом: \n 50 LTL \n 100 LTL \n 200 LTL");
            ZodynasLt_Ru.Add("nuskaiciuota nuo saskaitos.", "снято со счета. ");
            ZodynasLt_Ru.Add("Idekite pinigus i anga", "Положите деньги в отверстие");
            ZodynasLt_Ru.Add("Galimi tik siu nominalu banknotai: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR ",
                "Возможны банкноты номиналом: \n 10 EUR \n 20 EUR \n 50 EUR \n 100 EUR ");
            ZodynasLt_Ru.Add(" EUR inesta i saskaita. ", " EUR положено на счет. ");
            ZodynasLt_Ru.Add("Inesama suma lygi ", "Внесенная сумма ");
            ZodynasLt_Ru.Add("Galimi tik siu nominalu banknotai:  \n 50 LTL \n 100 LTL \n 200 LTL ",
                "Возможны банкноты номиналом:  \n 50 LTL \n 100 LTL \n 200 LTL ");
            ZodynasLt_Ru.Add("Pasirinkite: \n 1 - Grizti i meniu \n 0 - Uzbaigti darba", "Выберите: \n 1 - Главное меню \n 0 - Окончание работы");
            ZodynasLt_Ru.Add("Viso gero. Paimkite savo kortele", "Возьмите свою карту. Желаем хорошего дня.");
            ZodynasLt_Ru.Add("Jusu likutis: ", "Остаток на счету: ");
            ZodynasLt_Ru.Add("Iveskite nauja PIN. \n min 4 skaiciai, max 6 skaiciai", "Введите новый PIN. \n min 4 цифры, max 6 цифр");
            ZodynasLt_Ru.Add("PIN kodas gali buti sudarytas tik is skaiciu [0-9]", "PIN может быть только из цифр [0-9]");
            ZodynasLt_Ru.Add("Jusu PIN pakeistas", "Ваш PIN изменен");
            ZodynasLt_Ru.Add("Klaida. PIN kodas neatitinka formato. Ilgis 4-6 skaiciai", "Ошибка. PIN не соответствует формату. Длина: 4-6 цифр");
            ZodynasLt_Ru.Add("Gavejas: ", "Получатель: ");
            ZodynasLt_Ru.Add("Gavejo saskaitos numeris: ", "Номер счета получателя.: ");
            ZodynasLt_Ru.Add("Mokejimo paskirtis: ", "Назначение платежа: ");
            ZodynasLt_Ru.Add("Suma: ", "Сумма: ");
            ZodynasLt_Ru.Add(" 1 - Pavedimas EUR \n 0 - Pavedimas LTL", " 1 - Перевод в EUR \n 0 - Перевод в LTL");
            ZodynasLt_Ru.Add("Virsijamas dienos limitas", "Дневной лимит превышен");
            ZodynasLt_Ru.Add("Operacija sekmingai ivykdyta", "Оплата совершена");
            ZodynasLt_Ru.Add("Saskaitoje nepakanka lesu", "Недостаточно средств");
            ZodynasLt_Ru.Add("Klaida. Neteisingai suvesta informacija", "Ошибка. Неправильный ввод");
            ZodynasLt_Ru.Add("apmoketa ", "оплачено ");
            ZodynasLt_Ru.Add("Dienos limitas: ", "Оставшийся дневной лимит: ");
            ZodynasLt_Ru.Add("Klaida. Neteisingai ivesta suma [0.00]", "Ошибка. Неправильно введенная сумма [0.00]");
            ZodynasLt_Ru.Add("Naujas Pin: ", "Новый Pin: ");
            ZodynasLt_Ru.Add("Likutis: ", "Остаток: ");
        }
        static void IvestiNaujaPin()
        {
            if (kalbosPasirinkimas == 1)
            {
                IvestiNaujaPinVertejas();
            }
            if (kalbosPasirinkimas == 2)
            {
                IvestiNaujaPinVertejas();
            }
            if (kalbosPasirinkimas == 3)
            {
                IvestiNaujaPinVertejas();
            }
            IrasasPin();

        }
        static void IvestiNaujaPinVertejas()
        {
            Pause();
            Clean();
            Console.WriteLine(Vertejas("Iveskite nauja PIN. \n min 4 skaiciai, max 6 skaiciai"));
            string naujasPin = Console.ReadLine();
            bool skaiciai = naujasPin.All(char.IsDigit);


            if (skaiciai != true)
            {
                Console.WriteLine(Vertejas("PIN kodas gali buti sudarytas tik is skaiciu [0-9]"));
                Pause();
                IvestiNaujaPin();
            }

            if (naujasPin.Length >= 4 && naujasPin.Length <= 6)
            {
                pin = naujasPin;
                Console.WriteLine(Vertejas("Jusu PIN pakeistas"));
                IrasasPin();
                Pause();
                TolimesnisVeiksmas();
            }

            else
            {
                Pause();
                Console.WriteLine(Vertejas("Klaida. PIN kodas neatitinka formato. Ilgis 4-6 skaiciai"));
                Pause();
                IvestiNaujaPin();
            }
        }
        static void AtliktiPavedima()
        {
            try
            {

                if (kalbosPasirinkimas == 1)
                {
                    Pause();
                    Clean();
                    decimal sumaEur;
                    decimal kursas = 3.45M;
                    Console.Write("Gavejas: ");
                    string gavejas = Console.ReadLine();
                    Console.Write("Gavejo saskaitos numeris: ");
                    string saskaita = Console.ReadLine();

                    Console.Write("Mokejimo paskirtis: ");
                    string paskirtis = Console.ReadLine();
                    Limitas();
                    Console.Write("Suma: ");
                    decimal suma = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine(" 1 - Pavedimas EUR \n 0 - Pavedimas LTL");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 0)
                    {
                        sumaEur = Math.Round(suma / kursas, 2);
                        if (sumaEur > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }

                        saskaitosLikutis = Convert.ToDecimal(saskaitosLikutis - sumaEur);
                        limitas = limitas - sumaEur;
                        operacijos.Add($"{suma} LTL / {sumaEur} EUR / {gavejas} / {saskaita} / {paskirtis} / apmoketa {DateTime.Now}");
                        Pause();
                        Clean();
                        Console.WriteLine("Gavejas: " + gavejas);
                        Console.WriteLine("Gavejo saskaitos numeris:  " + saskaita);
                        Console.WriteLine("Mokejimo paskirtis: " + paskirtis);
                        Console.WriteLine("Suma: " + suma + " LTL (" + sumaEur + " EUR)");
                        Console.WriteLine("Operacija sekmingai ivykdyta");

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = suma;
                        trn.Valiuta = "LTL";
                        trn.MokėjimoPaskirtis = paskirtis;
                        trn.Data = DateTime.Now;
                        trn.Informacija();
                        TranzakcijuSarasas.Add(trn);

                    }
                    else if (choice == 1)
                    {
                        saskaitosLikutis = saskaitosLikutis - suma;
                        limitas = limitas - suma;
                        operacijos.Add($"{suma} EUR / {gavejas} / {saskaita} / {paskirtis} / apmoketa {DateTime.Now}");
                        if (suma > limitas)
                        {
                            Console.WriteLine("Virsijamas dienos limitas");
                            TolimesnisVeiksmas();
                        }
                        Pause();
                        Clean();
                        Console.WriteLine("Gavejas: " + gavejas);
                        Console.WriteLine("Saskaita: " + saskaita);
                        Console.WriteLine("Mokejimo paskirtis: " + paskirtis);
                        Console.WriteLine("Suma: " + suma + " EUR (" + Math.Round(suma * kursas, 2) + " LTL)");
                        Console.WriteLine("Operacija sekmingai ivykdyta");

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = suma;
                        trn.Valiuta = "EUR";
                        trn.MokėjimoPaskirtis = paskirtis;
                        trn.Data = DateTime.Now;
                        trn.Informacija();
                        TranzakcijuSarasas.Add(trn);
                    }
                    else
                    {

                        Console.WriteLine("Klaida. Pradekite is naujo");
                        Pause();
                        Pause();
                        Meniu();
                    }

                    Pause();
                    Likutis();
                    Pause();
                    TolimesnisVeiksmas();

                }
                if (kalbosPasirinkimas == 2)
                {
                    Pause();
                    Clean();
                    decimal sumaEur;
                    decimal kursas = 3.45M;
                    Console.Write(Vertejas("Gavejas: "));
                    string gavejas = Console.ReadLine();
                    Console.Write(Vertejas("Gavejo saskaitos numeris: "));
                    string saskaita = Console.ReadLine();
                    Console.Write(Vertejas("Mokejimo paskirtis: "));
                    string paskirtis = Console.ReadLine();
                    Limitas();
                    Console.Write(Vertejas("Suma: "));
                    decimal suma = Convert.ToDecimal(Console.ReadLine());


                    Console.WriteLine(Vertejas(" 1 - Pavedimas EUR \n 0 - Pavedimas LTL"));
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 0)
                    {
                        sumaEur = Math.Round(suma / kursas, 2);
                        if (sumaEur > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }

                        saskaitosLikutis = Convert.ToDecimal(saskaitosLikutis - sumaEur);
                        limitas = limitas - sumaEur;
                        operacijos.Add($"{suma} LTL / {sumaEur} EUR / {gavejas} / {saskaita} / {paskirtis} /" + Vertejas("apmoketa ") + $"{DateTime.Now}");
                        Pause();
                        Clean();
                        Console.WriteLine(Vertejas("Gavejas: ") + gavejas);
                        Console.WriteLine(Vertejas("Gavejo saskaitos numeris: ") + saskaita);
                        Console.WriteLine(Vertejas("Mokejimo paskirtis: ") + paskirtis);
                        Console.WriteLine(Vertejas("Suma: ") + suma + " LTL (" + sumaEur + " EUR)");
                        Console.WriteLine(Vertejas("Operacija sekmingai ivykdyta"));

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = suma;
                        trn.Valiuta = "LTL";
                        trn.MokėjimoPaskirtis = paskirtis;
                        trn.Data = DateTime.Now;
                        trn.InformacijaEN();
                        TranzakcijuSarasas.Add(trn);
                    }
                    else if (choice == 1)
                    {
                        saskaitosLikutis = saskaitosLikutis - suma;
                        limitas = limitas - suma;
                        operacijos.Add($"{suma} EUR / {gavejas} / {saskaita} / {paskirtis} /" + Vertejas("apmoketa ") + $"{DateTime.Now}");
                        if (suma > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }
                        Pause();
                        Clean();
                        Console.WriteLine(Vertejas("Gavejas: ") + gavejas);
                        Console.WriteLine(Vertejas("Gavejo saskaitos numeris: ") + saskaita);
                        Console.WriteLine(Vertejas("Mokejimo paskirtis: ") + paskirtis);
                        Console.WriteLine(Vertejas("Suma: ") + suma + " EUR (" + Math.Round(suma * kursas, 2) + " LTL)");
                        Console.WriteLine(Vertejas("Operacija sekmingai ivykdyta"));

                        Pause();
                        Pause();


                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = suma;
                        trn.Valiuta = "EUR";
                        trn.MokėjimoPaskirtis = paskirtis;
                        trn.Data = DateTime.Now;
                        trn.InformacijaEN();
                        TranzakcijuSarasas.Add(trn);

                    }
                    else
                    {

                        Console.WriteLine(Vertejas("Klaida. Pradekite is naujo"));
                        Pause();
                        Pause();
                        Meniu();
                    }

                    Pause();
                    Likutis();
                    Pause();
                    TolimesnisVeiksmas();

                }
                if (kalbosPasirinkimas == 3)
                {
                    Pause();
                    Clean();
                    decimal sumaEur;
                    decimal kursas = 3.45M;
                    Console.Write(Vertejas("Gavejas: "));
                    string gavejas = Console.ReadLine();
                    Console.Write(Vertejas("Gavejo saskaitos numeris: "));
                    string saskaita = Console.ReadLine();
                    Console.Write(Vertejas("Mokejimo paskirtis: "));
                    string paskirtis = Console.ReadLine();
                    Limitas();
                    Console.Write(Vertejas("Suma: "));
                    decimal suma = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine(Vertejas(" 1 - Pavedimas EUR \n 0 - Pavedimas LTL"));
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 0)
                    {
                        sumaEur = Math.Round(suma / kursas, 2);
                        if (sumaEur > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }

                        saskaitosLikutis = Convert.ToDecimal(saskaitosLikutis - sumaEur);
                        limitas = limitas - sumaEur;
                        operacijos.Add($"{suma} LTL / {sumaEur} EUR / {gavejas} / {saskaita} / {paskirtis} /" + Vertejas("apmoketa ") + $"{DateTime.Now}");
                        Pause();
                        Clean();
                        Console.WriteLine(Vertejas("Gavejas: ") + gavejas);
                        Console.WriteLine(Vertejas("Gavejo saskaitos numeris: ") + saskaita);
                        Console.WriteLine(Vertejas("Mokejimo paskirtis: ") + paskirtis);
                        Console.WriteLine(Vertejas("Suma: ") + suma + " LTL (" + sumaEur + " EUR)");
                        Console.WriteLine(Vertejas("Operacija sekmingai ivykdyta"));

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = suma;
                        trn.Valiuta = "LTL";
                        trn.MokėjimoPaskirtis = paskirtis;
                        trn.Data = DateTime.Now;
                        trn.InformacijaRU();
                        TranzakcijuSarasas.Add(trn);
                    }
                    else if (choice == 1)
                    {
                        saskaitosLikutis = saskaitosLikutis - suma;
                        limitas = limitas - suma;
                        operacijos.Add($"{suma} EUR / {gavejas} / {saskaita} / {paskirtis} /" + Vertejas("apmoketa ") + $"{DateTime.Now}");
                        if (suma > limitas)
                        {
                            DienosLimitas();
                            TolimesnisVeiksmas();
                        }
                        Pause();
                        Clean();
                        Console.WriteLine(Vertejas("Gavejas: ") + gavejas);
                        Console.WriteLine(Vertejas("Gavejo saskaitos numeris: ") + saskaita);
                        Console.WriteLine(Vertejas("Mokejimo paskirtis: ") + paskirtis);
                        Console.WriteLine(Vertejas("Suma: ") + suma + " EUR (" + Math.Round(suma * kursas, 2) + " LTL)");
                        Console.WriteLine(Vertejas("Operacija sekmingai ivykdyta"));

                        Tranzakcija trn = new Tranzakcija();
                        trn.Suma = suma;
                        trn.Valiuta = "EUR";
                        trn.MokėjimoPaskirtis = paskirtis;
                        trn.Data = DateTime.Now;
                        trn.InformacijaRU();
                        TranzakcijuSarasas.Add(trn);
                    }
                    else
                    {

                        Console.WriteLine(Vertejas("Klaida. Pradekite is naujo"));
                        Pause();
                        Pause();
                        Meniu();
                    }

                    Pause();
                    Likutis();
                    Pause();
                    TolimesnisVeiksmas();

                }
            }
            catch (Exception)
            {
                Exception();
            }
        }
        static void GeneruotiIsrasa()
        {
            Pause();
            Clean();
            {

                foreach (var operacija in operacijos)
                {

                    if (!File.Exists(pathOperacijos))
                    {
                        string isvestis = operacija + Environment.NewLine;
                        File.WriteAllText(pathOperacijos, isvestis);
                    }
                    string papildomaIsvestis = operacija + Environment.NewLine;
                    File.AppendAllText(pathOperacijos, papildomaIsvestis);

                    Console.WriteLine(operacija);
                }
                Likutis();
                Pause();
                TolimesnisVeiksmas();
            }
        }
        static void IrasasPin()
        {
            string path = @"C:\Users\Eugenijus\Desktop\Mano\VCS2021\C#\PINirLIK.txt";
            if (kalbosPasirinkimas == 1)
            {
                if (!File.Exists(path))
                {
                    string isvestis = "Naujas Pin: " + pin + DateTime.Now + Environment.NewLine;
                    File.WriteAllText(path, isvestis);
                }
                string papildomasTekstas = "Naujas Pin: " + pin + DateTime.Now + Environment.NewLine;
                File.AppendAllText(path, papildomasTekstas);
            }
            if (kalbosPasirinkimas == 2)
            {
                if (!File.Exists(path))
                {
                    string isvestis = Vertejas("Naujas Pin: ") + pin + DateTime.Now + Environment.NewLine;
                    File.WriteAllText(path, isvestis);
                }
                string papildomasTekstas = Vertejas("Naujas Pin: ") + pin + DateTime.Now + Environment.NewLine;
                File.AppendAllText(path, papildomasTekstas);
            }
            if (kalbosPasirinkimas == 3)
            {
                if (!File.Exists(path))
                {
                    string isvestis = Vertejas("Naujas Pin: ") + pin + DateTime.Now + Environment.NewLine;
                    File.WriteAllText(path, isvestis);
                }
                string papildomasTekstas = Vertejas("Naujas Pin: ") + pin + DateTime.Now + Environment.NewLine;
                File.AppendAllText(path, papildomasTekstas);
            }
        }
               static void IrasasLikutis()
        {
            string path = @"C:\Users\Eugenijus\Desktop\Mano\VCS2021\C#\PINirLIK.txt";
            if (kalbosPasirinkimas == 1)
            {
                if (!File.Exists(path))
                {
                    string isvestis = "Likutis: " + saskaitosLikutis + " EUR" + DateTime.Now + Environment.NewLine;
                    File.WriteAllText(path, isvestis);
                }
                string papildomasTekstas = "Likutis: " + saskaitosLikutis + " EUR" + DateTime.Now + Environment.NewLine;
                File.AppendAllText(path, papildomasTekstas);
            }
            if (kalbosPasirinkimas == 2)
            {
                if (!File.Exists(path))
                {
                    string isvestis = Vertejas("Likutis: ") + saskaitosLikutis + " EUR" + DateTime.Now + Environment.NewLine;
                    File.WriteAllText(path, isvestis);
                }
                string papildomasTekstas = Vertejas("Likutis: ") + saskaitosLikutis + " EUR" + DateTime.Now + Environment.NewLine;
                File.AppendAllText(path, papildomasTekstas);
            }
            if (kalbosPasirinkimas == 3)
            {
                if (!File.Exists(path))
                {
                    string isvestis = Vertejas("Likutis: ") + saskaitosLikutis + " EUR" + DateTime.Now + Environment.NewLine;
                    File.WriteAllText(path, isvestis);
                }
                string papildomasTekstas = Vertejas("Likutis: ") + saskaitosLikutis + " EUR" + DateTime.Now + Environment.NewLine;
                File.AppendAllText(path, papildomasTekstas);
            }
        }
        static void SkaitytiTxt()
        {
            string text = File.ReadAllText(pathOperacijos);
            Console.WriteLine(text);
            TolimesnisVeiksmas();
        }
                private static void ZiuretiGlobal()
        {
            foreach (var item in TranzakcijuSarasas)
            {
                item.Informacija();
            }
            TolimesnisVeiksmas();
        }

    }
}
