
namespace SportShop.SportStore.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("SportStore.Product")]
    [BasedOnRow(typeof(Entities.ProductRow), CheckNames = true)]
    public class ProductColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProductId { get; set; }
        [EditLink]
        public String Name { get; set; }
        [DisplayFormat("#,##0.00")]
        public Decimal UnitPrice { get; set; }
        public Int32 UnitsInStock { get; set; }
        public String Brand { get; set; }
        [DisplayFormat("#,##0.00")]
        public Decimal Weight { get; set; }
        [DisplayFormat("#,##0.00")]
        public Decimal Itbis { get; set; }
        [Width(200)]
        public String Description { get; set; }
    }
}