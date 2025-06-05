using System;
using System.Collections.Generic;
using Modul14_2311104012.Models;

namespace Modul14_2311104012.Services
{
    /// <summary>
    /// Layanan untuk mengelola data mahasiswa.
    /// </summary>
    public class MahasiswaService
    {
        private List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        public void TambahMahasiswa(Mahasiswa mahasiswa)
        {
            daftarMahasiswa.Add(mahasiswa);
            Console.WriteLine("Mahasiswa berhasil ditambahkan.\n");
        }

        public void TampilkanSemua()
        {
            Console.WriteLine("=== Daftar Mahasiswa ===");
            foreach (var mahasiswa in daftarMahasiswa)
            {
                Console.WriteLine(mahasiswa);
                Console.WriteLine("--------------------------");
            }
        }
    }
}
