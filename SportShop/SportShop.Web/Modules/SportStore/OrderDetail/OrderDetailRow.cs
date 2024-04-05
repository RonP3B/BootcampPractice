
namespace SportShop.SportStore.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("SportStore"), Module("SportStore"), TableName("[dbo].[OrderDetail]")]
    [DisplayName("Order Detail"), InstanceName("Order Detail")]
    [ReadPermission("SportStore:General")]
    [ModifyPermission("Administration:General")]
    public sealed class OrderDetailRow : Row, IIdRow
    {
        [DisplayName("Order Detail Id"), Identity]
        public Int32? OrderDetailId
        {
            get { return Fields.OrderDetailId[this]; }
            set { Fields.OrderDetailId[this] = value; }
        }

        [DisplayName("Order"), NotNull, ForeignKey("[dbo].[Order]", "OrderId"), LeftJoin("jOrder"), TextualField("OrderShipAddress")]
        public Int32? OrderId
        {
            get { return Fields.OrderId[this]; }
            set { Fields.OrderId[this] = value; }
        }

        [DisplayName("Product"), NotNull, ForeignKey("[dbo].[Product]", "ProductId"), LeftJoin("jProduct"), TextualField("ProductName")]
        [LookupEditor(typeof(ProductRow))]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Quantity"), Size(19), Scale(5), NotNull]
        public Decimal? Quantity
        {
            get { return Fields.Quantity[this]; }
            set { Fields.Quantity[this] = value; }
        }

        [DisplayName("Total Price"), Expression("(jProduct.[UnitPrice] * T0.[Quantity])")]
        [AlignRight, DisplayFormat("#,##0.00")]
        public Decimal? TotalPrice
        {
            get { return Fields.TotalPrice[this]; }
            set { Fields.TotalPrice[this] = value; }
        }

        [DisplayName("Total ITBS"), Expression("(jProduct.[ITBIS] * T0.[Quantity])")]
        [AlignRight, DisplayFormat("#,##0.00")]
        public Decimal? TotalItbis
        {
            get { return Fields.TotalItbis[this]; }
            set { Fields.TotalItbis[this] = value; }
        }

        [DisplayName("Order Customer Id"), Expression("jOrder.[CustomerId]")]
        public Int32? OrderCustomerId
        {
            get { return Fields.OrderCustomerId[this]; }
            set { Fields.OrderCustomerId[this] = value; }
        }

        [DisplayName("Order Order Date"), Expression("jOrder.[OrderDate]")]
        public DateTime? OrderOrderDate
        {
            get { return Fields.OrderOrderDate[this]; }
            set { Fields.OrderOrderDate[this] = value; }
        }

        [DisplayName("Order Deadline Date"), Expression("jOrder.[DeadlineDate]")]
        public DateTime? OrderDeadlineDate
        {
            get { return Fields.OrderDeadlineDate[this]; }
            set { Fields.OrderDeadlineDate[this] = value; }
        }

        [DisplayName("Order Shipped Date"), Expression("jOrder.[ShippedDate]")]
        public DateTime? OrderShippedDate
        {
            get { return Fields.OrderShippedDate[this]; }
            set { Fields.OrderShippedDate[this] = value; }
        }

        [DisplayName("Order Ship Address"), Expression("jOrder.[ShipAddress]")]
        public String OrderShipAddress
        {
            get { return Fields.OrderShipAddress[this]; }
            set { Fields.OrderShipAddress[this] = value; }
        }

        [DisplayName("Product Name"), Expression("jProduct.[Name]")]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }

        [DisplayName("Product Description"), Expression("jProduct.[Description]")]
        public String ProductDescription
        {
            get { return Fields.ProductDescription[this]; }
            set { Fields.ProductDescription[this] = value; }
        }

        [DisplayName("Product Unit Price"), Expression("jProduct.[UnitPrice]")]
        public Decimal? ProductUnitPrice
        {
            get { return Fields.ProductUnitPrice[this]; }
            set { Fields.ProductUnitPrice[this] = value; }
        }

        [DisplayName("Product Units In Stock"), Expression("jProduct.[UnitsInStock]")]
        public Int32? ProductUnitsInStock
        {
            get { return Fields.ProductUnitsInStock[this]; }
            set { Fields.ProductUnitsInStock[this] = value; }
        }

        [DisplayName("Product Brand"), Expression("jProduct.[Brand]")]
        public String ProductBrand
        {
            get { return Fields.ProductBrand[this]; }
            set { Fields.ProductBrand[this] = value; }
        }

        [DisplayName("Product Weight"), Expression("jProduct.[Weight]"), MinSelectLevel(SelectLevel.List)]
        public Decimal? ProductWeight
        {
            get { return Fields.ProductWeight[this]; }
            set { Fields.ProductWeight[this] = value; }
        }

        [DisplayName("Product Itbis"), Expression("jProduct.[ITBIS]")]
        public Decimal? ProductItbis
        {
            get { return Fields.ProductItbis[this]; }
            set { Fields.ProductItbis[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.OrderDetailId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OrderDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderDetailId;
            public Int32Field OrderId;
            public Int32Field ProductId;
            public DecimalField Quantity;

            public Int32Field OrderCustomerId;
            public DateTimeField OrderOrderDate;
            public DateTimeField OrderDeadlineDate;
            public DateTimeField OrderShippedDate;
            public StringField OrderShipAddress;

            public StringField ProductName;
            public StringField ProductDescription;
            public DecimalField ProductUnitPrice;
            public Int32Field ProductUnitsInStock;
            public StringField ProductBrand;
            public DecimalField ProductWeight;
            public DecimalField ProductItbis;

            public DecimalField TotalPrice;
            public DecimalField TotalItbis;
        }
    }
}
