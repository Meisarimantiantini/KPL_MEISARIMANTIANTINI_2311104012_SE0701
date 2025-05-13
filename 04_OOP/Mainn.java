public class Mainn {
    public static void main(String[] args) {
        // Contoh penggunaan KodePos
        System.out.println("Kode Pos Batununggal: " + KodePos.getKodePos("Batununggal"));
        System.out.println("Kode Pos Kujangsari: " + KodePos.getKodePos("Kujangsari"));
        
        // Contoh penggunaan DoorMachine
        DoorMachine pintu = new DoorMachine();
        pintu.toggleDoor(); // Membuka pintu
        pintu.toggleDoor(); // Mengunci pintu kembali
    }
}