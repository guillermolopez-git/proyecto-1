using Microsoft.AspNetCore.Mvc;
using CodexApp.Services;


namespace CodexApp.Controllers
{
    [ApiController]
    [Route("api/QuerySaldo")]
    public class QuerySaldoController : ControllerBase
    {
        private readonly QuerySaldo _querySaldo;//* Se declara una variable de solo lectura de tipo QuerySaldo.
        private readonly InitialDataController _initialData;

        public QuerySaldoController(QuerySaldo querySaldo, InitialDataController initialData)
        {
            _querySaldo = querySaldo;
            _initialData = initialData;
        }

        // GET api/QuerySaldo/{pin}
        [HttpGet("{pin}")]
        public IActionResult GetSaldo(int pin)
        {
            try
            {
                var creditCards = _initialData.Creditcards;
                var creditCard = creditCards.Find(c => c.Pin == pin);//* Busca la tarjeta de crédito con el pin proporcionado.

                if (creditCard != null)
                {
                    var saldoInfo = _querySaldo.QuerySaldobyPin(pin, creditCard);//* Obtiene la información de saldo de la tarjeta de crédito.
                    if (saldoInfo != null)
                    {
                        return Ok(saldoInfo);//* Devuelve la información de saldo de la tarjeta de crédito.
                    }
                    else
                    {
                        return NotFound("No se encontró información de saldo para el PIN proporcionado.");
                    }
                }
                else
                {
                    return NotFound("Tarjeta no encontrada");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);//* Devuelve un error 400 con el mensaje de la excepción.
            }
        }

        // GET api/QuerySaldo
        [HttpGet]
        public IActionResult GetAllSaldo()
        {
            try
            {
                var allSaldoInfo = _querySaldo.GetAllSaldoInfo();//* Obtiene la información de saldo de todas las tarjetas de crédito.
                return Ok(allSaldoInfo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
