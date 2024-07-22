

namespace Practica_SRP.BLL
{
    public class Comunicaciones : INotificacion
    {
        private readonly INotificacion notificacion;

        public Comunicaciones(INotificacion notificacion)
        {
            this.notificacion = notificacion;
        }
        public void EnviarCorreo(string Mensaje)
        {
            const string Correo = "CorreoEjemplo@gmail.com";
            const string clave = "12345";
            var Datos = Mensaje;

           
        }
    }
}
