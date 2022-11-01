using Telegram.Bot.Types;

namespace Ucu.Poo.TelegramBot
{
    /// <summary>
    /// Un "handler" del patrón Chain of Responsibility que implementa el comando "direccion".
    /// </summary>
    public class DireccionHandler : BaseHandler
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DireccionHanlder"/>. Esta clase procesa el mensaje "direccion"
        /// </summary>
        /// <param name="next">El próximo "handler".</param>
        public DireccionHandler(BaseHandler next) : base(next)
        {
            this.Keywords = new string[] { "direccion", "Direccion" };
        }

        /// <summary>
        /// Procesa el mensaje "direccion" y retorna true; retorna false en caso contrario.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override void InternalHandle(Message message, out string response)
        {
            response = "Ingrese su dirección";
        }
    }
}