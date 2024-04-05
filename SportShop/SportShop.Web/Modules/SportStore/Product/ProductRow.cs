
namespace SportShop.SportStore.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("SportStore"), Module("SportStore"), TableName("[dbo].[Product]")]
    [DisplayName("Products"), InstanceName("Product")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("SportStore.Product", Permission = "SportStore:General")]
    public sealed class ProductRow : Row, IIdRow, INameRow
    {
        [DisplayName("Product Id"), Identity]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Description"), Size(200), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Unit Price"), Size(19), Scale(4), NotNull, QuickSearch, LookupInclude]
        public Decimal? UnitPrice
        {
            get { return Fields.UnitPrice[this]; }
            set { Fields.UnitPrice[this] = value; }
        }

        [DisplayName("Units In Stock"), NotNull]
        public Int32? UnitsInStock
        {
            get { return Fields.UnitsInStock[this]; }
            set { Fields.UnitsInStock[this] = value; }
        }

        [DisplayName("Brand"), Size(200), QuickSearch]
        public String Brand
        {
            get { return Fields.Brand[this]; }
            set { Fields.Brand[this] = value; }
        }

        [DisplayName("Weight (KG)"), Size(19), Scale(5), NotNull]
        public Decimal? Weight
        {
            get { return Fields.Weight[this]; }
            set { Fields.Weight[this] = value; }
        }

        [DisplayName("ITBIS"), Column("ITBIS"), Size(19), Scale(5), NotNull, LookupInclude]
        public Decimal? Itbis
        {
            get { return Fields.Itbis[this]; }
            set { Fields.Itbis[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ProductId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProductId;
            public StringField Name;
            public StringField Description;
            public DecimalField UnitPrice;
            public Int32Field UnitsInStock;
            public StringField Brand;
            public DecimalField Weight;
            public DecimalField Itbis;
        }
    }
}
