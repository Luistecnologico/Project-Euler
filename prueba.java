import java.util.*;

public class Main {
    public static void main(String[] args) throws Exception {
        // Codificamos propiedades
        
        miFuncion(Botones.Back, true);
        System.out.println("-----------");
        miFuncion(Botones.App, true);
        System.out.println("-----------");
        miFuncion(Botones.Home, true);
        System.out.println("-----------");
        miFuncion(Botones.Back, false);
        System.out.println("-----------");
        miFuncion(Botones.App, false);
        System.out.println("-----------");
        miFuncion(Botones.Home, false);
    }
    
    private static String propiedades[] = new String[5];
    
    private static void miFuncion(Botones boton, boolean sw) {
        
        List<String> cadenaAux = new ArrayList<String>();
        
        for (int i = 0; i < propiedades.length; i++) {
            if (propiedades[i] == "" || propiedades[i] == null) {
                break;
            }
            cadenaAux.add(propiedades[i]);
            propiedades[i] = "";
        }
        
        if (sw) {
            if (!cadenaAux.contains(boton.getBoton())) {
                cadenaAux.add(boton.getBoton());
            }
        } else {
            cadenaAux.remove(boton.getBoton());
        }
        
        if (cadenaAux.size() == 0) {
            System.out.println("Aqui se desabilita");
        }
        
        for (int i = 0; i < cadenaAux.size(); i++) {
            propiedades[i] = cadenaAux.get(i);
            System.out.println("propiedades[" + i +"] = " + cadenaAux.get(i));
        }
    }
    
    public static enum Botones 
    {
        Back("back"), 
        Home("home"), 
        App("App");
     
        private String boton;
     
        Botones(String enBoton) {
            this.boton = enBoton;
        }
     
        public String getBoton() {
            return boton;
        }
    }
}
