using CodexApp.Models;
using CodexApp.Models.Events;
using System.Diagnostics;

namespace CodexApp.Services
{
    public class PinUpdate
    {
        private int notificationId = 0;

        public event EventHandler<PinUpdateEvent>? PinUpdateEv;

        private PinNode? head;

        public PinUpdate()
        {
            head = null;
        }

        public void UpdatePins(int pin, int updatedPin, Creditcard card)
        {
            if (card != null && card.Pin == pin)
            {
                card.Pin = updatedPin;
                OnPinUpdate(pin, updatedPin); 

                var pinsData = new PinChangeUpdate(pin, updatedPin);
                AddPinChangeRequest(pinsData);
            }
        }


        public void ProcessPinChanges()
        {
            var current = head;
            while (current != null)
            {
                var pinChange = current.Data;
                var notificationMsg = $"Alerta: Se ha actualizado el PIN de la tarjeta con el PIN {pinChange!.Pin}, al PIN {pinChange!.UpdatedPin}";
                var notification = new Notification(notificationId++, notificationMsg);
                Console.WriteLine($"{notification.Message}");
                current = current.Next;
            }
        }


        protected virtual void OnPinUpdate(int pin, int updatedPin)
        {
            var eventArgs = new PinUpdateEvent
            {
                Pin = pin,
                UpdatedPin = updatedPin
            };
            // Invocamos el evento
            PinUpdateEv?.Invoke(this, eventArgs);
        }





        public void AddPinChangeRequest(PinChangeUpdate pinChange)
        {
            if (head == null)
            {
                head = new PinNode(pinChange);
                return;
            }

            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new PinNode(pinChange);
        }


        public IEnumerable<PinChangeUpdate> GetAllPinChangeRequests()
        {
            var pinChangeRequests = new List<PinChangeUpdate>();
            var current = head;
            while (current != null)
            {
                pinChangeRequests.Add(current.Data!);
                current = current.Next;
            }
            return pinChangeRequests;
        }
    }


}
