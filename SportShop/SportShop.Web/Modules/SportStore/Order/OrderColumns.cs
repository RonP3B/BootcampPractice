
namespace SportShop.SportStore.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("SportStore.Order")]
    [BasedOnRow(typeof(Entities.OrderRow), CheckNames = true)]
    public class OrderColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 OrderId { get; set; }
        [EditLink, DisplayName("Customer"), Width(170)]
        public String CustomerName { get; set; }
        [EditLink, Width(150)]
        public DateTime OrderDate { get; set; }
        [Width(170)]
        public OrderStatus OrderStatus { get; set; }
        [Width(150)]
        public DateTime DeadlineDate { get; set; }
        [Width(200)]
        public String ShipAddress { get; set; }
    }
}