using System;

namespace MyProject
{
    class ProgramEntry
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Pilih program yang akan dijalankan:");
                Console.WriteLine("1. Membalikan Nama");
                Console.WriteLine("2. Kelompok Hari");
                Console.WriteLine("3. Hitung Rata-Rata Nilai");
                Console.WriteLine("4. Program Nilai Siswa");
                Console.WriteLine("0. Keluar");

                Console.Write("Masukkan pilihan Anda: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Siswa.MembalikanNama.Start(args);
                        break;
                    case "2":
                        Siswa.KelompokHari.Start();
                        break;
                    case "3":
                        Siswa.HitungRataRataNilai.Start(args);
                        break;
                    case "4":
                        Siswa.ProgramNilaiSiswa.Start(args);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }
            }
        }
    }
}
