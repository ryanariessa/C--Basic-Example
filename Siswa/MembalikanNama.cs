using System;

namespace MyProject.Siswa
{
    class MembalikanNama
    {
        public static void Start(string[] args)
        {
            Console.Write("Masukkan teks: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            Array.Reverse(words);

            Console.WriteLine("Hasil balik:");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
        }
    }
}
