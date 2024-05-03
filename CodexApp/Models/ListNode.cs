using static CodexApp.Services.QuerySaldo;

namespace CodexApp.Models
{
    public class ListNode
    {
        public SaldoInfo? SaldoInfo { get; set; }
        public ListNode? Next { get; set; }

        public ListNode(SaldoInfo saldoInfo)//Constructor de la clase ListNode
        {
            SaldoInfo = saldoInfo;
            Next = null;
        }                                                                                           

    }
}
        