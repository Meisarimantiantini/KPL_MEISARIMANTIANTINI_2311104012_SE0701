public class Main {
    public static void main(String[] args) {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Nama Praktikan");
        video.PrintVideoDetails();
        video.IncreasePlayCount(10000);
        video.PrintVideoDetails();

        try {
            video.IncreasePlayCount(20000000);
        } catch (Exception e) {
            System.out.println("Terjadi kesalahan: " + e.getMessage());
        }
    }
}