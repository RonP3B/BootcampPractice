
namespace SportShop.SportStore.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("SportStore.OrderDetail")]
    [BasedOnRow(typeof(Entities.OrderDetailRow), CheckNames = true)]
    public class OrderDetailColumns
    {
        [EditLink, DisplayName("Product"), Width(150)]
        public String ProductName { get; set; }
        [DisplayName("Price")]
        public Decimal ProductUnitPrice { get; set; }
        [DisplayName("ITBIS")]
        public Decimal ProductItbis { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal TotalPrice { get; set; }
        public Decimal TotalItbis { get; set; }

    }
}