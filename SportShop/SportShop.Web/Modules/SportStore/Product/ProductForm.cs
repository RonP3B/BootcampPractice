
namespace SportShop.SportStore.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportStore.Product")]
    [BasedOnRow(typeof(Entities.ProductRow), CheckNames = true)]
    public class ProductForm
    {
        [Category("General")]
        public String Name { get; set; }
        public String Description { get; set; }
        public String Brand { get; set; }
        public Decimal Weight { get; set; }
        [Category("Pricing")]
        public Decimal UnitPrice { get; set; }
        public Int32 UnitsInStock { get; set; }
        public Decimal Itbis { get; set; }
    }
}