using System;

class Modul02  // ✅ Ubah nama class
{
    public static void Run()  // ✅ Ubah Main() jadi Run()
    {
        // 1. Menerima input nama
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!");

        // 2. Membuat array dengan 50 elemen
        int[] array = new int[50];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
            if (i % 2 == 0 && i % 3 == 0)
                Console.WriteLine($"{i} #$#$");
            else if (i % 2 == 0)
                Console.WriteLine($"{i} ##");
            else if (i % 3 == 0)
                Console.WriteLine($"{i} $$");
            else
                Console.WriteLine(i);
        }

        // 3. Menerima input angka dan mengecek bilangan prima
        Console.Write("Masukkan angka (1-10000): ");
        int nilai = Convert.ToInt32(Console.ReadLine());
        if (IsPrime(nilai))
            Console.WriteLine($"Angka {nilai} merupakan bilangan prima");
        else
            Console.WriteLine($"Angka {nilai} bukan merupakan bilangan prima");
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
