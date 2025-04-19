using System;
using System.IO;
using System.Text.Json;

namespace TP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deserialisasi Data Mahasiswa:");
            var dataMahasiswa = new DataMahasiswa2311104012();
            dataMahasiswa.ReadJSON();

            Console.WriteLine("\nDeserialisasi Kuliah Mahasiswa:");
            var kuliahMahasiswa = new KuliahMahasiswa2311104012();
            kuliahMahasiswa.ReadJSON();
        }
    }

    public class DataMahasiswa2311104012
    {
        public class Mahasiswa
        {
            public string nama_depan { get; set; }
            public string nama_belakang { get; set; }
            public string nim { get; set; }
            public string fakultas { get; set; }
        }

        public void ReadJSON()
        {
            string path = "tp7_1_2311104012.json";
            string jsonString = File.ReadAllText(path);
            var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
            Console.WriteLine($"Nama {mahasiswa.nama_depan} {mahasiswa.nama_belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
    }

    public class KuliahMahasiswa2311104012
    {
        public class MataKuliah
        {
            public string kode_mk { get; set; }
            public string nama_mk { get; set; }
        }

        public class Kuliah
        {
            public MataKuliah[] daftar_matkul { get; set; }
        }

        public void ReadJSON()
        {
            string path = "tp7_2_2311104012.json";
            string jsonString = File.ReadAllText(path);
            var kuliah = JsonSerializer.Deserialize<Kuliah>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var mk in kuliah.daftar_matkul)
            {
                Console.WriteLine($"MK {i} {mk.kode_mk} - {mk.nama_mk}");
                i++;
            }
        }
    }
}
