import java.util.HashMap;
import java.util.Map;

class KodeBuah {
    private static final Map<String, String> kodeBuahMap = new HashMap<>();
    
    static {
        kodeBuahMap.put("Apel", "A00");
        kodeBuahMap.put("Aprikot", "B00");
        kodeBuahMap.put("Alpukat", "C00");
        kodeBuahMap.put("Pisang", "D00");
        kodeBuahMap.put("Paprika", "E00");
        kodeBuahMap.put("Kurma", "K00");
        kodeBuahMap.put("Durian", "L00");
        kodeBuahMap.put("Anggur", "M00");
        kodeBuahMap.put("Melon", "N00");
        kodeBuahMap.put("Semangka", "O00");
    }
    
    public static String getKodeBuah(String namaBuah) {
        return kodeBuahMap.getOrDefault(namaBuah, "Kode tidak ditemukan");
    }
}
