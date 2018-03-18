namespace Contracts
{
    public class ManualRejectData : AbstractTradeData
    {
        public int UserId { get; set; }

        public string Reason { get; set; }
    }
}
