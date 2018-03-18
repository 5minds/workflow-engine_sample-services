namespace App.SharedDataStore
{
    using Contracts;

    public class DataStoreItem
    {
        public string CorrelationId { get; set; }
        public AbstractTradeData Data { get; set; }
    }
}
