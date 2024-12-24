using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Cotxe vehicle1 = new Cotxe("Urus", "Lamborghini", 2022, 250.0, 4);

        // Mostrar la informació del vehicle
        vehicle1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Cotxe vehicle2 = new Cotxe("Murcielago", "Lamborghini", 1965, 220.0, 2);
        
        // Mostrar la informació del segon vehicle
        vehicle2.MostrarInformacio();
    }
}
