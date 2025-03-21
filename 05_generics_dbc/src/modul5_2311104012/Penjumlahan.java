package modul5_2311104012;

public class Penjumlahan {
    public static <T extends Number> double jumlahTigaAngka(T a, T b, T c) {
        return a.doubleValue() + b.doubleValue() + c.doubleValue();
    }

    public static void main(String[] args) {
        System.out.println("Hasil Penjumlahan: " + jumlahTigaAngka(2, 3, 4));
        System.out.println("Hasil Penjumlahan: " + jumlahTigaAngka(1.5, 2.5, 3.5));
    }
}
