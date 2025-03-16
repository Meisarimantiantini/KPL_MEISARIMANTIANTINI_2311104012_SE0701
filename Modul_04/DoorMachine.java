public class DoorMachine {
    private String state;
    
    public DoorMachine() {
        this.state = "Terkunci";
        System.out.println("Pintu terkunci");
    }
    
    public void toggleDoor() {
        if (state.equals("Terkunci")) {
            state = "Terbuka";
            System.out.println("Pintu tidak terkunci");
        } else {
            state = "Terkunci";
            System.out.println("Pintu terkunci");
        }
    }
}
