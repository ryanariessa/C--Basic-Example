using System;

namespace MyProject.Siswa
{
    class KelompokHari
    {
        public static void Start()
        {
            string[] daysOfWeek = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };

            Console.WriteLine("Nama hari:");
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {daysOfWeek[i]}");
            }

            Console.WriteLine("\nKelompok nama hari genap:");
            for (int i = 0; i < daysOfWeek.Length; i += 2)
            {
                Console.WriteLine($"{daysOfWeek[i]}");
            }

            Console.WriteLine("\nKelompok nama hari ganjil:");
            for (int i = 1; i < daysOfWeek.Length; i += 2)
            {
                Console.WriteLine($"{daysOfWeek[i]}");
            }
        }
    }
}