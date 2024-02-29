using System;

namespace MyProject.Siswa
{
    class ProgramNilaiSiswa
    {
        public static void Start(string[] args)
        {
            Console.Write("Masukkan jumlah siswa: ");
            int jumlahSiswa = int.Parse(Console.ReadLine());

            Console.Write("Masukkan jumlah mata pelajaran: ");
            int jumlahMataPelajaran = int.Parse(Console.ReadLine());

            string[] namaSiswa = new string[jumlahSiswa];
            double[,] nilaiSiswa = new double[jumlahSiswa, jumlahMataPelajaran];
            string[] namaMataPelajaran = new string[jumlahMataPelajaran];

            // Input nama siswa
            for (int i = 0; i < jumlahSiswa; i++)
            {
                Console.Write($"Masukkan nama siswa ke-{i + 1}: ");
                namaSiswa[i] = Console.ReadLine();
            }

            // Input nama mata pelajaran
            for (int i = 0; i < jumlahMataPelajaran; i++)
            {
                Console.Write($"Masukkan nama mata pelajaran ke-{i + 1}: ");
                namaMataPelajaran[i] = Console.ReadLine();
            }

            // Input nilai mata pelajaran
            for (int i = 0; i < jumlahSiswa; i++)
            {
                Console.WriteLine($"Nilai untuk siswa {namaSiswa[i]}:");
                for (int j = 0; j < jumlahMataPelajaran; j++)
                {
                    Console.Write($"Masukkan nilai {namaMataPelajaran[j]} untuk siswa {namaSiswa[i]}: ");
                    nilaiSiswa[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Menghitung rata-rata nilai setiap siswa
            double[] rataRataNilai = new double[jumlahSiswa];
            for (int i = 0; i < jumlahSiswa; i++)
            {
                double totalNilai = 0;
                for (int j = 0; j < jumlahMataPelajaran; j++)
                {
                    totalNilai += nilaiSiswa[i, j];
                }
                rataRataNilai[i] = totalNilai / jumlahMataPelajaran;
            }

            // Mencari siswa dengan nilai rata-rata tertinggi dan terendah
            double nilaiTertinggi = double.MinValue;
            double nilaiTerendah = double.MaxValue;
            string siswaTertinggi = "";
            string siswaTerendah = "";

            for (int i = 0; i < jumlahSiswa; i++)
            {
                if (rataRataNilai[i] > nilaiTertinggi)
                {
                    nilaiTertinggi = rataRataNilai[i];
                    siswaTertinggi = namaSiswa[i];
                }

                if (rataRataNilai[i] < nilaiTerendah)
                {
                    nilaiTerendah = rataRataNilai[i];
                    siswaTerendah = namaSiswa[i];
                }
            }

            // Menampilkan hasil
            Console.WriteLine($"Siswa dengan nilai rata-rata tertinggi adalah: {siswaTertinggi} dengan nilai {nilaiTertinggi}");
            Console.WriteLine($"Siswa dengan nilai rata-rata terendah adalah: {siswaTerendah} dengan nilai {nilaiTerendah}");
        }
    }
}
