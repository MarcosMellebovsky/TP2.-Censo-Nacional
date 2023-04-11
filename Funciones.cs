public static class Funciones
{
    public static string IngresarTexto(string mensaje)    
    {
        string text = "";
        while (text == "")
        {
            Console.Write(mensaje);
            text = Console.ReadLine();
        }
        return text;
    }
      public static int IngresarEntero(string msj)
    {
        int entero=-1;
        while (entero == -1)
        {   
            Console.Write(msj);
            int.TryParse(Console.ReadLine(), out entero);
        }
        return entero;
    }
     public static DateTime IngresarFecha(string msj)
    {
        DateTime fechaDate;
        string fechaCadena = IngresarTexto(msj);
        while (!DateTime.TryParse(fechaCadena, out fechaDate))
        {
            fechaCadena = IngresarTexto("ERROR! " + msj);
        }
        return fechaDate;
    }

}