
namespace SportShop.SportStore.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportStore.Order")]
    [BasedOnRow(typeof(Entities.OrderRow), CheckNames = true)]
    public class OrderForm
    {
        [Category("Order")]
        [HalfWidth]
        public DateTime OrderDate { get; set; }
        [HalfWidth]
        public DateTime DeadlineDate { get; set; }
        [HalfWidth]
        public DateTime ShippedDate { get; set; }
        [HalfWidth]
        public Int32 CustomerId { get; set; }
        public String ShipAddress { get; set; }
        [Category("Order Details")]
        [OrderDetailEditor]
        public List<Entities.OrderDetailRow> DetailList { get; set; }
    }
}