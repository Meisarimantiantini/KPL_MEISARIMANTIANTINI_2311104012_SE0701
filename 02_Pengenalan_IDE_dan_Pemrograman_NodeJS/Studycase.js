const readline = require('readline');
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

// Array untuk menyimpan daftar barang
let barang = [];

// Fungsi untuk meminta input dari pengguna
function inputBarang() {
    rl.question("Masukkan jumlah jenis barang yang dibeli: ", (jumlahBarang) => {
        jumlahBarang = parseInt(jumlahBarang);
        let counter = 0;

        function inputDetailBarang() {
            if (counter < jumlahBarang) {
                rl.question(`Masukkan nama barang ke-${counter + 1}: `, (nama) => {
                    rl.question(`Masukkan jumlah ${nama}: `, (jumlah) => {
                        rl.question(`Masukkan harga per unit ${nama}: `, (harga) => {
                            barang.push({ nama, jumlah: parseInt(jumlah), harga: parseInt(harga) });
                            counter++;
                            inputDetailBarang();
                        });
                    });
                });
            } else {
                hitungTotalDanDiskon();
            }
        }
        inputDetailBarang();
    });
}

// Fungsi untuk menghitung total harga dan menentukan diskon
function hitungTotalDanDiskon() {
    let totalHarga = 0;
    let jumlahBarang = barang.length;

    barang.forEach(item => {
        totalHarga += item.harga * item.jumlah;
    });

    let kategoriDiskon;
    if (totalHarga > 100000) {
        kategoriDiskon = "Diskon Besar";
    } else if (totalHarga >= 50000) {
        kategoriDiskon = "Diskon Sedang";
    } else {
        kategoriDiskon = "Tidak Ada Diskon";
    }

    console.log("\n=== Hasil Perhitungan ===");
    console.log("Total Harga: Rp" + totalHarga);
    console.log("Jumlah Barang: " + jumlahBarang);
    console.log("Kategori Diskon: " + kategoriDiskon);
    console.log("Detail Barang:");
    barang.forEach(item => {
        console.log(`- ${item.nama} (Jumlah: ${item.jumlah}, Harga: Rp${item.harga} per unit)`);
    });
    rl.close();
}

// Mulai program
inputBarang();