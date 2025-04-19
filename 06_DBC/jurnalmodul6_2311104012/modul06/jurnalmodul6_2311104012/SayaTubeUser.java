package modul06.jurnalmodul6_2311104012;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;


public class SayaTubeUser {
    private int id;
    private String username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(String username) {
        if (username == null || username.length() > 100) {
            throw new IllegalArgumentException("Username tidak boleh null dan maksimal 100 karakter.");
        }
        this.id = new Random().nextInt(90000) + 10000;
        this.username = username;
        this.uploadedVideos = new ArrayList<>();
    }

    public void AddVideo(SayaTubeVideo video) {
        if (video == null) {
            throw new IllegalArgumentException("Video tidak boleh null.");
        }
        if (video.getPlayCount() > Integer.MAX_VALUE) {
            throw new ArithmeticException("Play count video melebihi batas integer.");
        }
        this.uploadedVideos.add(video);
    }

    public int GetTotalVideoPlayCount() {
        int total = 0;
        for (SayaTubeVideo video : uploadedVideos) {
            total += video.getPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlaycount() {
        System.out.println("User: " + this.username);
        for (int i = 0; i < Math.min(8, uploadedVideos.size()); i++) {
            System.out.println("Video " + (i + 1) + " judul: " + uploadedVideos.get(i).getTitle());
        }
    }
}

