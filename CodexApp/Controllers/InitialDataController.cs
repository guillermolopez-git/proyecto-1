using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using CodexApp.Models;

using CodexApp.Models.Events;
using CodexApp.Services;



namespace CodexApp.Controllers
{
    [ApiController]
    [Route("api/InitialData")]
    public class InitialDataController : ControllerBase
    {
        private readonly List<Creditcard> _creditCards;
        private readonly PagoQueue _pagoQueue;
        private readonly AumentoLimiteStack _aumentoLimiteStack;
        private readonly PinUpdate _pinUpdate;


            
        public InitialDataController(PagoQueue pagoQueue, AumentoLimiteStack aumentoLimiteStack, PinUpdate pinUpdate)
        {

            _creditCards = new List<Creditcard>();
            _pagoQueue = pagoQueue;
            _aumentoLimiteStack = aumentoLimiteStack;
            _pinUpdate = pinUpdate;

            string jsonFile = "./Data/credit_cards.json";
            string jsonString = System.IO.File.ReadAllText(jsonFile);

            _creditCards.AddRange(JsonSerializer.Deserialize<List<Creditcard>>(jsonString)!);

            // suscribimos el manejador de eventos
            _pagoQueue.SaldoUpdate += HandleSaldoUpdate;
            _aumentoLimiteStack.LimiteUpdate += HandleAumentoLimite;
            _pinUpdate.PinUpdateEv += HandlePinUpdate;
        }

        public List<Creditcard> Creditcards => _creditCards;
        //Se agrega la propiedad Creditcards para que sea accesible desde otros controladores.
       
        public delegate void SaldoUpdateEventHandler(object sender, SaldoUpdateEvent e);
        public delegate void AumentoLimiteEventHandler(object sender, LimiteUpdateEvent e);



        private void HandleSaldoUpdate (object? sender, SaldoUpdateEvent e)
        {
            var card = _creditCards.FirstOrDefault(c => c.Pin == e.Pin);
            if(sender != null )
            {
                if (card != null)
                {
                    card.Saldo = e.UpdatedSaldo;
                }
            }
            else
            {
                card = null;
            }
        }

        private void HandleAumentoLimite(object? sender, LimiteUpdateEvent e)
        {
            var card = _creditCards.FirstOrDefault(c => c.Pin == e.Pin);
            if (sender != null)
            {
                if (card != null)
                {
                    card.Limite = e.UpdatedLimite;
                }
            }

        }

        private void HandlePinUpdate(object? sender, PinUpdateEvent e)
        {
            var card = _creditCards.FirstOrDefault(c => c.Pin == e.Pin);
            if (sender != null)
            {
                if (card != null)
                {
                    card.Pin = e.UpdatedPin;
                }
            }
        }



        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_creditCards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }   
        }
    
    }
}
