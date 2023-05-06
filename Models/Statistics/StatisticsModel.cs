namespace RestaurantManagementOrder.Models.Statistics
{
    public class MostExpensiveTableInfo
    {
        public int TableNum { get; set; }
        public int TotalPrice { get; set; }
    }

    public class StatisticsModel
    {
        public Order BiggestOrderByQuantity { get; set; }
        public Order BiggestOrderByPrice { get; set; }
        // (table #, total price)
        public MostExpensiveTableInfo MostExpensiveTable { get; set; }
    }
}
