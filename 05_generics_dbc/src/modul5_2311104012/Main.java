package modul5_2311104012;

public class Main {
    public static void main(String[] args) {
        System.out.println("Halo, program berhasil dijalankan!");

        // Menggunakan SimpleDataBase untuk menyimpan angka
        SimpleDataBase<Integer> db = new SimpleDataBase<>();
        db.addData(12);
        db.addData(34);
        db.addData(56);
        db.printAll();
    }
}
