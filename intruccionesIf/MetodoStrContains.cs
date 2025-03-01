using System;

public class strContains{
    public void strContainss() {    

        

        string txt = "El rápido zorro marrón salta sobre el perro perezoso.";
        bool resultado = txt.Contains("perro");
        Console.WriteLine(resultado);

        if (txt.Contains("zorro")) {
            Console.WriteLine("¿Qué dice el zorro?");
        }
    }
}