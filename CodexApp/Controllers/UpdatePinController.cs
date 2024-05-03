using CodexApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodexApp.Controllers
{
    [ApiController]
    [Route("api/UpdatePin")]
    public class UpdatePinController : Controller
    {
        private readonly PinUpdate _pinUpdate;
        private readonly InitialDataController _initialData;

        public UpdatePinController(PinUpdate pinUpdate, InitialDataController initialData)
        {
            _pinUpdate = pinUpdate;
            _initialData = initialData;
        }

        [HttpGet("{pin}/{newPin}")]
        public IActionResult ChangePin(int pin , int newPin)
        {
            
            var creditCards = _initialData.Creditcards;
            var creditCard = creditCards.Find(c => c.Pin == pin);
            if (creditCard != null)
            {
                _pinUpdate.UpdatePins(pin, newPin, creditCard);
                _pinUpdate.ProcessPinChanges();
                return Ok("Pin actualizado");
            }
            else
            {
                return NotFound("No se encontró información de saldo para el PIN proporcionado.");
            }
            
        }

        [HttpPost]
        public IActionResult GetAllChangedPins()
        {
            var changedPins = _pinUpdate.GetAllPinChangeRequests();
            return Ok(changedPins);
        }
       
       
    }
}
