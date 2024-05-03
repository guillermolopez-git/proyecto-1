using CodexApp.Models;
using CodexApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodexApp.Controllers
{
    [ApiController]
    [Route("api/pagos")]
    public class PayRequestController : Controller
    {
        private readonly PagoQueue _pagoQueue; // Para agregar pagos a la cola
        private readonly InitialDataController _initialData; // Informacion de las tarjetas de credito
        private readonly QuerySaldo _querySaldo;// Para los eventos 


        public PayRequestController(PagoQueue pagoQueue, InitialDataController initialData, QuerySaldo querySaldo)
        {
            _pagoQueue = pagoQueue;
            _initialData = initialData;
            _querySaldo = querySaldo;
        }


        [HttpPost("{pin}")]
        public IActionResult MakePago(int pin, string descripcion , decimal monto)
        {

            var creditCards = _initialData.Creditcards;
            var creditCard = creditCards.Find(c => c.Pin == pin);
            var limit = creditCard?.Limite;
           

            

            if (creditCard!= null)
            {

                _pagoQueue.UpdateSaldo(pin, creditCard!, descripcion!, monto);
                _pagoQueue.ProcessPayments();
                return Ok("Pago Recibido");
            }
            else
            {
                return NotFound("No se encontró información de saldo para el PIN proporcionado.");
            }



        }


    }
}
