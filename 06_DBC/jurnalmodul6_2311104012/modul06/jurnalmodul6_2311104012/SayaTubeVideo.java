package modul06.jurnalmodul6_2311104012;
import java.util.Random;

public class SayaTubeVideo {
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title) {
        if (title == null || title.length() > 200) {
            throw new IllegalArgumentException("Judul video tidak boleh null dan maksimal 200 karakter.");
        }
        this.id = new Random().nextInt(90000) + 10000;
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count) {
        if (count > 25000000 || count < 0) {
            throw new IllegalArgumentException("Maksimal play count per tambah = 25 juta.");
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

    public int getPlayCount() {
        return this.playCount;
    }

    public String getTitle() {
        return this.title;
    }
}

