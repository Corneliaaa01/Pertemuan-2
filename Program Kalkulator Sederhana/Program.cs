using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Silakan pilih operasi: ");
            Console.WriteLine("1. Penjumlahan (+)");
            Console.WriteLine("2. Pengurangan (-)");
            Console.WriteLine("3. Perkalian (*)");
            Console.WriteLine("4. Pembagian (/)");

            Console.Write("Masukkan pilihan: ");
            string pilihan = Console.ReadLine();

            Console.Write("Masukkan angka pertama: ");
            double angka1 = double.Parse(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double angka2 = double.Parse(Console.ReadLine());

            double hasil = 0;

            switch (pilihan)
            {
                case "1":
                case "+":
                    hasil = angka1 + angka2;
                    Console.WriteLine("Hasil: " + hasil);
                    break;
                case "2":
                case "-":
                    hasil = angka1 - angka2;
                    Console.WriteLine("Hasil: " + hasil);
                    break;
                case "3":
                case "*":
                    hasil = angka1 * angka2;
                    Console.WriteLine("Hasil: " + hasil);
                    break;
                case "4":
                case "/":
                    hasil = angka1 / angka2;
                    Console.WriteLine("Hasil: " + hasil);
                    break;
                default:
                    Console.WriteLine("Maaf, pilihan yang Anda masukkan tidak valid.");
                    break;
            }

            Console.WriteLine("Tekan enter untuk melanjutkan atau ketik \"exit\" untuk keluar...");
            string keluar = Console.ReadLine();
            if (keluar.ToLower() == "exit")
            {
                break;
            }
        }

    }
}
