

namespace Practica_SRP.Clase
{
    public class Persona
    {
        private string? nombre;
        private int edad;
        private string? direccion;
        private string correoElectronico;


        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;

        }




        public void ImprimirEnConsola()
        {
            // Lógica para imprimir información en la consola
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Dirección: {direccion}");
            Console.WriteLine($"Correo Electronico: {correoElectronico}");
        }
    }
}
