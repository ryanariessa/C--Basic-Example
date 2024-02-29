using System;

namespace MyProject.Siswa
{
    class HitungRataRataNilai
    {
        public static void Start(string[] args)
        {
            Console.Write("Masukkan jumlah mata pelajaran yang diikuti: ");
            int jumlahMataPelajaran = Convert.ToInt32(Console.ReadLine());

            double totalNilai = 0;

            for (int i = 1; i <= jumlahMataPelajaran; i++)
            {
                Console.Write("Masukkan nilai untuk mata pelajaran ke-{0}: ", i);
                double nilai = Convert.ToDouble(Console.ReadLine());
                totalNilai += nilai;
            }

            double rataRata = totalNilai / jumlahMataPelajaran;

            Console.WriteLine("Nilai rata-rata siswa adalah: {0}", rataRata);
        }
    }
}
