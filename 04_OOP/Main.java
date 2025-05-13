public class Main {
    public static void main(String[] args) {
        // Contoh penggunaan KodeBuah
        System.out.println("Kode buah Apel: " + KodeBuah.getKodeBuah("Apel"));
        System.out.println("Kode buah Pisang: " + KodeBuah.getKodeBuah("Pisang"));
        
        // Contoh penggunaan PosisiKarakterGame
        PosisiKarakterGame karakter = new PosisiKarakterGame();
        long nim = 2311104012L; // Sesuai NIM Anda
        karakter.tekanTombol('S', nim);
        karakter.tekanTombol('W', nim);
    }
}