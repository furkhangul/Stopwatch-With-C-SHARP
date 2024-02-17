using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int saniye = 0;
            int dakika = 0;
            int saat = 0;

            while (true) // Sonsuz döngü
            {
                Console.WriteLine($"{saat:D2}:{dakika:D2}:{saniye:D2}"); // Saat formatını yazdır

                // Saniyeyi artır
                saniye++;
                if (saniye == 60)
                {
                    saniye = 0;
                    dakika++;

                    if (dakika == 60)
                    {
                        dakika = 0;
                        saat++;

                        if (saat == 24)
                        {
                            saat = 0;
                        }
                    }
                }

                System.Threading.Thread.Sleep(1000); // 1 saniye bekle
                Console.Clear(); // Konsolu temizle
            }
        }
    }
}
