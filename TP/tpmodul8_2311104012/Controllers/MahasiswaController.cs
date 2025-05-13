using Microsoft.AspNetCore.Mvc;
using tpmodul8_2311104012.Models;

namespace tpmodul8_2311104012.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Meisarimantiantini", Nim = "2311104012" },
            new Mahasiswa { Nama = "Teman1", Nim = "2311104001" },
            new Mahasiswa { Nama = "Teman2", Nim = "2311104002" }
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get() => daftarMahasiswa;

        [HttpGet("{index}")]
        public Mahasiswa Get(int index) => daftarMahasiswa[index];

        [HttpPost]
        public void Post([FromBody] Mahasiswa m) => daftarMahasiswa.Add(m);

        [HttpDelete("{index}")]
        public void Delete(int index) => daftarMahasiswa.RemoveAt(index);
    }
}
