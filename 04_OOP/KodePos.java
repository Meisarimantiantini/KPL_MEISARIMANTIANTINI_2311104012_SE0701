import java.util.HashMap;
import java.util.Map;

public class KodePos {
    private static final Map<String, String> kodePosMap = new HashMap<>();
    
    static {
        kodePosMap.put("Batununggal", "40266");
        kodePosMap.put("Kujangsari", "40287");
        kodePosMap.put("Mengger", "40267");
        kodePosMap.put("Wates", "40256");
        kodePosMap.put("Cijaura", "40287");
        kodePosMap.put("Jatisari", "40286");
        kodePosMap.put("Margasari", "40286");
        kodePosMap.put("Sekejati", "40286");
        kodePosMap.put("Kebonwaru", "40272");
        kodePosMap.put("Maleer", "40274");
        kodePosMap.put("Samoja", "40273");
    }
    
    public static String getKodePos(String kelurahan) {
        return kodePosMap.getOrDefault(kelurahan, "Kode tidak ditemukan");
    }
}
