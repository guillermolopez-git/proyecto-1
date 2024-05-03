﻿using CodexApp.Models;
using CodexApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CodexApp.Controllers
{
    [ApiController]
    [Route("api/aumentoLimite")]
    public class AumentoLimiteController : ControllerBase
    {
        private readonly AumentoLimiteStack _aumentoLimiteStack;
        private readonly InitialDataController _initialData;

        public AumentoLimiteController(AumentoLimiteStack aumentoLimiteStack, InitialDataController initialData)
        {
            _aumentoLimiteStack = aumentoLimiteStack;
            _initialData = initialData;
        }

        [HttpGet]
        public IActionResult AumentarLimite(int pin, int limite)
        {



            var creditCards = _initialData.Creditcards;
            var creditCard = creditCards.Find(c => c.Pin == pin);


            if (creditCard != null)
            {
                _aumentoLimiteStack.ProcessRequest(pin, creditCard, limite);


                return Ok("Limite de la tarjeta actualizado");
            }
            else
            {
                return NotFound("No se encontró información de saldo para el PIN proporcionado.");
            }
        }

        [HttpPost]
        public IActionResult GetAllLimite()
        {
            var aumentos = _aumentoLimiteStack.GetAllRequests();
            return Ok(aumentos);



        }
    }
}