using CodexApp.Models;
using CodexApp.Models.Events;


namespace CodexApp.Services
{
    public class AumentoLimiteStack
    {
        private int notificationId = 0;

        public event EventHandler<LimiteUpdateEvent>? LimiteUpdate;

        private readonly Stack<AumentoLimite> aumentoLimiteStack = new Stack<AumentoLimite>();
        private readonly List<AumentoLimite> processedRequests = new List<AumentoLimite>();

        public void AddRequest(AumentoLimite aumentoRequest)
        {
            aumentoLimiteStack.Push(aumentoRequest);
        }

        public void ProcessIncrease()
        {
           
            foreach (var aumentoRequest in aumentoLimiteStack)
            {
                var notificationMsg = $"Alerta: se realizó un aumento de límite de {aumentoRequest.NuevoLimite}";
                var notification = new Notification(notificationId++, notificationMsg);
                Console.WriteLine($"Mensaje: {notification.Message}");

                
                processedRequests.Add(aumentoRequest);
            }

           
            aumentoLimiteStack.Clear();
        }

        public void ProcessRequest(int pin, Creditcard card, int Limite)
        {
            if (card != null && card.Pin == pin)
            {
                card.Limite = Limite;// Reemplazamos el viejo limite por el nuevo
                OnLimitUpdate(pin, card.Limite);

                var limitData = new AumentoLimite(pin, Limite);
                AddRequest(limitData);
            }
        }

        protected virtual void OnLimitUpdate(int pin, int limite)
        {
            var eventArgs = new LimiteUpdateEvent
            {
                Pin = pin,
                UpdatedLimite = limite
            };

            // Invocamos el evento
            LimiteUpdate?.Invoke(this, eventArgs);
        }

        
        public IEnumerable<AumentoLimite> GetAllRequests()
        {
         
            var allRequests = new List<AumentoLimite>(aumentoLimiteStack);
            allRequests.AddRange(processedRequests);
            return allRequests;
        }
    }
}
