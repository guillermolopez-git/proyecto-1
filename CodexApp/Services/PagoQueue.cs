using CodexApp.Models;
using CodexApp.Models.Events;
using System;

namespace CodexApp.Services
{
    public class PagoQueue
    {
        private int notificationId = 0;

        public event EventHandler<SaldoUpdateEvent>? SaldoUpdate;

        private readonly Queue<PagoRequest> paymentQueue = new Queue<PagoRequest>();

        public void AddToQueue(PagoRequest pagoRequest)
        {
            paymentQueue.Enqueue(pagoRequest);
        }

        public void ProcessPayments()
        {
            while (paymentQueue.Count > 0)// Mientras haya pagos en la cola
            {
                var pagoRequest = paymentQueue.Dequeue();

                var notificationMsg = $"Alerta: se realizó un pago de {pagoRequest.Descripcion} con el monto de {pagoRequest.Monto}";

                var notification = new Notification(notificationId++, notificationMsg);
                Console.WriteLine($"{notification.Message}");
            }
        }

        protected virtual void OnSaldoUpdate(int pin , decimal updatedSaldo)
        {
            var eventArgs = new SaldoUpdateEvent
            {
                Pin = pin,
                UpdatedSaldo = updatedSaldo
            };
            // Invocamos el evento
            SaldoUpdate?.Invoke(this, eventArgs);
        }


        public void UpdateSaldo(int pin, Creditcard card, string descripcion, decimal monto )
        {
            if (card != null && card.Pin == pin)
            {
                card.Saldo += monto;// Sumaoms el monto al saldo de la tarjeta
                OnSaldoUpdate(pin, card.Saldo);

                var pagoData = new PagoRequest(pin, descripcion, monto);
                AddToQueue(pagoData);
            }
        }
    }
}
