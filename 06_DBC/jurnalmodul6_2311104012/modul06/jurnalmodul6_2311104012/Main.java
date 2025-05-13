package modul06.jurnalmodul6_2311104012;

public class Main {
    public static void main(String[] args) {
        SayaTubeUser user = new SayaTubeUser("Mei Sari");

        for (int i = 1; i <= 10; i++) {
            SayaTubeVideo video = new SayaTubeVideo("Review Film Ke-" + i + " oleh Mei Sari");
            video.IncreasePlayCount(10000 * i);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
        System.out.println("Total Play Count: " + user.GetTotalVideoPlayCount());
    }
}

