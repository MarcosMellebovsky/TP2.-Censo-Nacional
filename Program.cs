List<Persona> listaPersonas = new List<Persona>();
int opciones;
//menu
do
{
Console.Clear();
System.Console.WriteLine("A que opcion desea entrer: ");
System.Console.WriteLine("Opcion 1: Cargar Nueva Persona");
System.Console.WriteLine("Opcion 2: Obtener Estadísticas del Censo ");
System.Console.WriteLine("Opcion 3: Buscar Persona");
System.Console.WriteLine("Opcion 4: Modificar Mail de una Persona");
System.Console.WriteLine("Opcion 5: Salir");
opciones = int.Parse(Console.ReadLine());
Console.Clear();
switch (opciones)
{
    case 1:
    CargarNuevaPersona();
    break;
    case 2:
    ObtenerEstadísticasdelCenso();
    break;
    case 3:
    BuscarPersona();
    break;
    case 4:
    ModificarMailDeUnaPersona();
    break;
} 
} while (opciones!=5);
// 1. carga de personas
void CargarNuevaPersona()
{
    string nom = Funciones.IngresarTexto("Ingrese su nombre:");
    string ape = Funciones.IngresarTexto("Ingrese su apellido: ");
    int dni = Funciones.IngresarEntero("Ingrese dni:");
  foreach (Persona item in listaPersonas)
  {
    while (dni == item.DNI)
    {
        System.Console.WriteLine("Dni ya ingresado vove a ingresarlo!");
        dni = int.Parse(Console.ReadLine());
    }   
  }
    DateTime fn = Funciones.IngresarFecha("Ingrese su fecha de nacimiento:(aaaa/mm/dd) ");
    string mail = Funciones.IngresarTexto("Ingrese su mail:");
    Persona persona1 = new Persona(dni, nom , ape , fn ,mail);
    listaPersonas.Add(persona1);
}
// 2. estadisticas 
void ObtenerEstadísticasdelCenso()
{
    int cantidadDePersonas = 0;
    int personasQuePuedenVotar16 = 0;
    int acum = 0;
    

    cantidadDePersonas = listaPersonas.Count;
    System.Console.WriteLine("Cantidad de personas: " + cantidadDePersonas);
    Persona cantPersonasQuePuedenVotar = new Persona();
    Persona Persona16 =  new Persona();
    personasQuePuedenVotar16 = Persona16.personasQuePuedenVotar();
    System.Console.WriteLine("Personas que pueden votar: " + personasQuePuedenVotar16);
    foreach (Persona item in listaPersonas)
    {
      acum = acum + item.obtenerEdad();
    }
    if (cantidadDePersonas == 0)
    {
      System.Console.WriteLine("Aún no se ingresaron personas en la lista!");
      
    }
    else
    {
      System.Console.WriteLine("El promedio de edades es: " + acum / cantidadDePersonas); 
    }
    Console.ReadLine();
}
//3.Bucar la persona 
void BuscarPersona()
{
  int buscarDni;
  bool loEncontre = false;
  System.Console.WriteLine("Ingrese su dni: ");
  buscarDni = int.Parse(Console.ReadLine());
  foreach (Persona item in listaPersonas)
  {
    if (buscarDni == item.DNI)
    {
      Console.WriteLine(" El nombre es: " + " " + item.Nombre + " " + " el apellido es: " + " " + item.Apellido + " " + " el dni es: " + " " + item.DNI + "" + " la fecha de Nacimiento es: " + " " + item.FechaDeNacimiento + " el mail es: " +  item.Email);
      loEncontre = true;
    }
  }
  if (loEncontre == false)
  {
    System.Console.WriteLine("No se encuentra el DNI");
  }
  Console.ReadLine();
}
// 4. modificar el mail de una persona 
void ModificarMailDeUnaPersona()
{
  int dniBucar;
  string nuevoMail;
  bool encontre = false;
  System.Console.WriteLine("Ingrese su dni: ");
  dniBucar= int.Parse(Console.ReadLine());
  foreach (Persona item in listaPersonas)
  {
    if (dniBucar == item.DNI)
  {
    System.Console.WriteLine("Ingrese su mail nuevo: ");
    nuevoMail = Console.ReadLine();
    item.Email = nuevoMail;
    encontre = true;
  }
  }
  if (encontre == false)
  {
    System.Console.WriteLine("No se encuentra el DNI");
    Console.ReadLine();
  }
}