using System;
using System.IO;
using System.Text.Json;

namespace JurnalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deserialisasi Data Mahasiswa:");
            var dataMahasiswa = new DataMahasiswa2311104012();
            dataMahasiswa.ReadJSON();

            Console.WriteLine("\nDeserialisasi Anggota Tim:");
            var team = new TeamMembers2311104012();
            team.ReadJSON();

            Console.WriteLine("\nDeserialisasi Glossary:");
            var glossary = new GlossaryItem2311104012();
            glossary.ReadJSON();
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
            string path = "jurnal7_1_2311104012.json";
            string jsonString = File.ReadAllText(path);
            var mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
            Console.WriteLine($"Nama {mhs.nama_depan} {mhs.nama_belakang} dengan NIM {mhs.nim} dari fakultas {mhs.fakultas}");
        }
    }

    public class TeamMembers2311104012
    {
        public class Anggota
        {
            public string nim { get; set; }
            public string nama_depan { get; set; }
            public string nama_belakang { get; set; }
            public int umur { get; set; }
            public string jenis_kelamin { get; set; }
        }

        public class Tim
        {
            public Anggota[] anggota { get; set; }
        }

        public void ReadJSON()
        {
            string path = "jurnal7_2_2311104012.json";
            string jsonString = File.ReadAllText(path);
            var tim = JsonSerializer.Deserialize<Tim>(jsonString);
            Console.WriteLine("Team member list:");
            foreach (var a in tim.anggota)
            {
                Console.WriteLine($"{a.nim} {a.nama_depan} {a.nama_belakang} ({a.umur} {a.jenis_kelamin})");
            }
        }
    }

    public class GlossaryItem2311104012
    {
        public class GlossDef
        {
            public string para { get; set; }
            public string[] GlossSeeAlso { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class Root
        {
            public Glossary glossary { get; set; }
        }

        public void ReadJSON()
        {
            string path = "jurnal7_3_2311104012.json";
            string jsonString = File.ReadAllText(path);
            var glossary = JsonSerializer.Deserialize<Root>(jsonString);
            var entry = glossary.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("GlossEntry:");
            Console.WriteLine($"ID: {entry.ID}");
            Console.WriteLine($"GlossTerm: {entry.GlossTerm}");
            Console.WriteLine($"Acronym: {entry.Acronym}");
            Console.WriteLine($"Abbrev: {entry.Abbrev}");
            Console.WriteLine($"GlossDef: {entry.GlossDef.para}");
            Console.WriteLine($"GlossSee: {entry.GlossSee}");
        }
    }
}
