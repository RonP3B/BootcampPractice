
namespace SportShop.SportStore.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportStore.OrderDetail")]
    [BasedOnRow(typeof(Entities.OrderDetailRow), CheckNames = true)]
    public class OrderDetailForm
    {
        public Int32 ProductId { get; set; }
        [DefaultValue(1)]
        public Int32 Quantity { get; set; }
    }
}