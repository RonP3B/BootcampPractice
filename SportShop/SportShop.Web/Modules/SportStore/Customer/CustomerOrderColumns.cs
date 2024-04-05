
namespace SportShop.SportStore.Columns
{
    using Serenity.ComponentModel;
    using System;

    [ColumnsScript("SportStore.CustomerOrder")]
    [BasedOnRow(typeof(Entities.OrderRow))]
    public class CustomerOrderColumns
    {
        [Width(150)]
        public DateTime OrderDate { get; set; }
        [Width(150)]
        public DateTime DeadlineDate { get; set; }
        [Width(200)]
        public OrderStatus OrderStatus { get; set; }
        [Width(200)]
        public String ShipAddress { get; set; }
    }

}