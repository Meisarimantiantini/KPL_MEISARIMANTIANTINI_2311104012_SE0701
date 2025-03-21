package modul5_2311104012;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class SimpleDataBase<T> {
    private List<T> data = new ArrayList<>();
    private List<Date> timestamps = new ArrayList<>();

    public void addData(T item) {
        data.add(item);
        timestamps.add(new Date());
    }

    public void printAll() {
        for (int i = 0; i < data.size(); i++) {
            System.out.println("Data ke-" + (i+1) + ": " + data.get(i) + " | Waktu: " + timestamps.get(i));
        }
    }

    public static void main(String[] args) {
        SimpleDataBase<Integer> db = new SimpleDataBase<>();
        db.addData(12);
        db.addData(34);
        db.addData(56);
        db.printAll();
    }
}
