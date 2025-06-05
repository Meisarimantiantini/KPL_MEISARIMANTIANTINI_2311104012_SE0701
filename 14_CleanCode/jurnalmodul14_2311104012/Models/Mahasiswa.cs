namespace Modul14_2311104012.Models
{
    /// <summary>
    /// Kelas untuk menyimpan informasi mahasiswa.
    /// </summary>
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public string Jurusan { get; set; }

        public Mahasiswa(string nama, string nim, string jurusan)
        {
            Nama = nama;
            NIM = nim;
            Jurusan = jurusan;
        }

        public override string ToString()
        {
            return $"Nama    : {Nama}\nNIM     : {NIM}\nJurusan : {Jurusan}";
        }
    }
}
