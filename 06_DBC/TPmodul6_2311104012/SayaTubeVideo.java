import java.util.Random;

public class SayaTubeVideo {
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title) {
        if (title == null || title.length() > 100) {
            throw new IllegalArgumentException("Judul video harus antara 1-100 karakter.");
        }

        this.id = new Random().nextInt(90000) + 10000;
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count) {
        if (count > 10000000 || count < 0) {
            throw new IllegalArgumentException("Maksimal play count per tambah = 10 juta.");
        }
        if ((long) this.playCount + count > Integer.MAX_VALUE) {
            throw new ArithmeticException("Play count melebihi batas integer.");
        }

        this.playCount += count;
    }

    public void PrintVideoDetails() {
        System.out.println("ID: " + this.id);
        System.out.println("Title: " + this.title);
        System.out.println("Play Count: " + this.playCount);
    }
}
