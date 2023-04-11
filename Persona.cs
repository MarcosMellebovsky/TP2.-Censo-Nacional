class Persona
{   public int DNI{get;set;}
    public string Apellido{get ;set;} 
    public string Nombre{get;set;}
    public DateTime  FechaDeNacimiento{get;set;}
      public string Email{get;set;}
    public Persona(int dni = 0, string nom ="" , string ape = "", DateTime fn = new DateTime(), string mail = "")
    {
        DNI = dni;
        Nombre = nom; 
        Apellido = ape;
        FechaDeNacimiento = fn;
        Email = mail;
    }
    public int personasQuePuedenVotar()
    {
        DateTime FechaNacimientoHoy = new DateTime(DateTime.Today.Year, FechaDeNacimiento.Month, FechaDeNacimiento.Day);
        int edad = 0;
        int puedeVotar = 0;
         edad = DateTime.Today.Year - FechaDeNacimiento.Year;
        
        if (FechaDeNacimiento > DateTime.Today.AddYears(-edad))
        {
            edad--;
        }
        if (edad >= 16)
        {
            puedeVotar++;
        }
        return puedeVotar;
    }
    public int obtenerEdad()
    {
        int edadd;
        edadd = DateTime.Today.Year - FechaDeNacimiento.Year;
        if (FechaDeNacimiento > DateTime.Today.AddYears(-edadd))
        {
            edadd--;
        }
        return edadd;
    }
   
}
