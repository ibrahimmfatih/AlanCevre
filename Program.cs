using System;

class AlanCevre
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("İşlem seçeneği:");
            Console.WriteLine("1 --> Hesaplama");
            Console.WriteLine("0 --> Çıkış");
            string islemSecim = Console.ReadLine();

            if (islemSecim == "0")
            {
                break;
            }   
            else if (islemSecim == "1")
            {
                string islemTuru;
                do
                {
                    Console.WriteLine("İşlem türü:");
                    Console.WriteLine("1 --> Alan");
                    Console.WriteLine("2 --> Çevre");
                    islemTuru = Console.ReadLine();

                    if (islemTuru != "1" && islemTuru != "2")
                    {
                        Console.WriteLine("Geçersiz işlem türü. Lütfen tekrar deneyin.");
                    }

                } while (islemTuru != "1" && islemTuru != "2");

                string sekilSecim;
                do
                {
                    Console.WriteLine("Geometrik şekil seçin:");
                    Console.WriteLine("1 --> Üçgen");
                    Console.WriteLine("2 --> Kare");
                    Console.WriteLine("3 --> Dikdörtgen");
                    Console.WriteLine("4 --> Daire");
                    sekilSecim = Console.ReadLine();

                    if (sekilSecim != "1" && sekilSecim != "2" && sekilSecim != "3" && sekilSecim != "4")
                    {
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    }

                } while (sekilSecim != "1" && sekilSecim != "2" && sekilSecim != "3" && sekilSecim != "4");

                switch (sekilSecim)
                {
                    case "1":
                        UcgenHesaplama(islemTuru);
                        break;
                    case "2":
                        KareHesaplama(islemTuru);
                        break;
                    case "3":
                        DikdortgenHesaplama(islemTuru);
                        break;
                    case "4":
                        DaireHesaplama(islemTuru);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            }
        }
    }

    static void UcgenHesaplama(string islemTuru)
    {
        string ucgenTipi;
        do
        {
            Console.WriteLine("Üçgen tipi seçin:");
            Console.WriteLine("1 --> Eşkenar üçgen");
            Console.WriteLine("2 --> İkizkenar üçgen");
            Console.WriteLine("3 --> Çeşitkenar üçgen");
            ucgenTipi = Console.ReadLine();

            if (ucgenTipi != "1" && ucgenTipi != "2" && ucgenTipi != "3")
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            }

        } while (ucgenTipi != "1" && ucgenTipi != "2" && ucgenTipi != "3");

        switch (ucgenTipi)
        {
            case "1":
                EskenarUcgenHesaplama(islemTuru);
                break;
            case "2":
                IkizkenarUcgenHesaplama(islemTuru);
                break;
            case "3":
                CesitkenarUcgenHesaplama(islemTuru);
                break;
            default:
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                break;
        }
    }

    static void EskenarUcgenHesaplama(string islemTuru)
    {
        double kenar = GetPositiveNumber("Kenar uzunluğunu girin: ");

        if (islemTuru == "1")
        {
            double alan = (Math.Sqrt(3) / 4) * Math.Pow(kenar, 2);
            Console.WriteLine("Eşkenar üçgenin alanı: " + alan);
        }
        else if (islemTuru == "2")
        {
            double cevre = 3 * kenar;
            Console.WriteLine("Eşkenar üçgenin çevresi: " + cevre);
        }
    }

    static void IkizkenarUcgenHesaplama(string islemTuru)
    {
        double kenar = GetPositiveNumber("Eşit kenar uzunluğunu girin: ");
        double taban = GetPositiveNumber("Taban uzunluğunu girin: ");

        if (islemTuru == "1")
        {
            double yukseklik = Math.Sqrt(Math.Pow(kenar, 2) - Math.Pow(taban / 2, 2));
            double alan = (taban * yukseklik) / 2;
            Console.WriteLine("İkizkenar üçgenin alanı: " + alan);
        }
        else if (islemTuru == "2")
        {
            double cevre = 2 * kenar + taban;
            Console.WriteLine("İkizkenar üçgenin çevresi: " + cevre);
        }
    }

    static void CesitkenarUcgenHesaplama(string islemTuru)
    {
        double kenar1 = GetPositiveNumber("Birinci kenar uzunluğunu girin: ");
        double kenar2 = GetPositiveNumber("İkinci kenar uzunluğunu girin: ");
        double kenar3 = GetPositiveNumber("Üçüncü kenar uzunluğunu girin: ");

        if (islemTuru == "1")
        {
            double s = (kenar1 + kenar2 + kenar3) / 2;
            double alan = Math.Sqrt(s * (s - kenar1) * (s - kenar2) * (s - kenar3));
            Console.WriteLine("Çeşitkenar üçgenin alanı: " + alan);
        }
        else if (islemTuru == "2")
        {
            double cevre = kenar1 + kenar2 + kenar3;
            Console.WriteLine("Çeşitkenar üçgenin çevresi: " + cevre);
        }
    }

    static void KareHesaplama(string islemTuru)
    {
        double kenar = GetPositiveNumber("Kenar uzunluğunu girin: ");

        if (islemTuru == "1")
        {
            double alan = Math.Pow(kenar, 2);
            Console.WriteLine("Karenin alanı: " + alan);
        }
        else if (islemTuru == "2")
        {
            double cevre = 4 * kenar;
            Console.WriteLine("Karenin çevresi: " + cevre);
        }
    }

    static void DikdortgenHesaplama(string islemTuru)
    {
        double uzunKenar = GetPositiveNumber("Uzun kenar uzunluğunu girin: ");
        double kisaKenar = GetPositiveNumber("Kısa kenar uzunluğunu girin: ");

        if (islemTuru == "1")
        {
            double alan = uzunKenar * kisaKenar;
            Console.WriteLine("Dikdörtgenin alanı: " + alan);
        }
        else if (islemTuru == "2")
        {
            double cevre = 2 * (uzunKenar + kisaKenar);
            Console.WriteLine("Dikdörtgenin çevresi: " + cevre);
        }
    }

    static void DaireHesaplama(string islemTuru)
    {
        double yaricap = GetPositiveNumber("Yarıçap uzunluğunu girin: ");

        if (islemTuru == "1")
        {
            double alan = Math.PI * Math.Pow(yaricap, 2);
            Console.WriteLine("Dairenin alanı: " + alan);
        }
        else if (islemTuru == "2")
        {
            double cevre = 2 * Math.PI * yaricap;
            Console.WriteLine("Dairenin çevresi: " + cevre);
        }
    }

    static double GetPositiveNumber(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out number) && number > 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
            }
        }
    }
}