using CodexApp.Models;


namespace CodexApp.Services
{
    public class QuerySaldo
    {
        private ListNode? head;//* Nodo inicial de la lista enlazada.

        
        public class SaldoInfo
        {
            public int Pin { get; set; }
            public int Limite { get; set; }
            public decimal Saldo { get; set; }
            public decimal SaldoDisp { get; set; }
        }

       
        public void AddSaldoInfo(SaldoInfo saldoInfo)
        {
            ListNode newNode = new(saldoInfo);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                ListNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        
        public List<SaldoInfo> GetAllSaldoInfo()
        {
            var saldoInfoList = new List<SaldoInfo>();
            var current = head;
            while (current != null)
            {
                saldoInfoList.Add(current.SaldoInfo!);
                current = current.Next;
            }
            return saldoInfoList;
        }

        
        public SaldoInfo? QuerySaldobyPin( Creditcard card)
        {
            
            var saldoInfo = new SaldoInfo
            { 
                Limite = card.Limite,
                Saldo = card.Saldo,
                SaldoDisp = card.SaldoDisp,
            };
            AddSaldoInfo(saldoInfo);
            return saldoInfo;
        }


     
    }
}
