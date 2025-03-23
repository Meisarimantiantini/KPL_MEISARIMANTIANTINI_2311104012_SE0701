class PosisiKarakterGame {
    private String posisi;
    
    public PosisiKarakterGame() {
        this.posisi = "Berdiri";
    }
    
    public void tekanTombol(char tombol, long nim) {
        if (nim % 3 == 0) {
            if (tombol == 'S') {
                posisi = "Duduk";
                System.out.println("Tombol arah bawah ditekan, karakter duduk");
            } else if (tombol == 'W') {
                posisi = "Berdiri";
                System.out.println("Tombol arah atas ditekan, karakter berdiri");
            } else {
                System.out.println("Tombol tidak dikenal");
            }
        } else if (nim % 3 == 1) {
            if (posisi.equals("Berdiri")) {
                posisi = "Tengkurap";
                System.out.println("Karakter tengkurap");
            } else if (posisi.equals("Tengkurap")) {
                posisi = "Berdiri";
                System.out.println("Karakter kembali berdiri");
            }
        } else if (nim % 3 == 2) {
            if (posisi.equals("Terbang")) {
                posisi = "Jongkok";
                System.out.println("Posisi landing, karakter jongkok");
            } else if (posisi.equals("Berdiri")) {
                posisi = "Terbang";
                System.out.println("Karakter take off");
            }
        }
    }
}