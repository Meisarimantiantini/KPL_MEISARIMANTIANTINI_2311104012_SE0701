package modul5_2311104012;

public class DataGeneric<T> {
    private T data;  // Data yang akan disimpan

    // Constructor untuk menyimpan data
    public DataGeneric(T data) {
        this.data = data;
    }

    // Method untuk mencetak data
    public void printData() {
        System.out.println("Data yang tersimpan adalah: " + data);
    }

    public static void main(String[] args) {
        // Simpan data berupa NIM
        DataGeneric<String> dataNIM = new DataGeneric<>("2311104012");
        dataNIM.printData();
    }
}
