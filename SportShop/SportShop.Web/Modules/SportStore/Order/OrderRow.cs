namespace SportShop.SportStore.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("SportStore"), Module("SportStore"), TableName("[dbo].[Order]")]
    [DisplayName("Orders"), InstanceName("Order")]
    [ReadPermission("SportStore:General")]
    [ModifyPermission("Administration:General")]
    public sealed class OrderRow : Row, IIdRow, INameRow, ICustomerOrderRow
    {
        [DisplayName("Order Id"), Identity]
        public Int32? OrderId
        {
            get { return Fields.OrderId[this]; }
            set { Fields.OrderId[this] = value; }
        }

        [DisplayName("Customer"), NotNull, ForeignKey("[dbo].[Customer]", "CustomerId"), LeftJoin("jCustomer"), TextualField("CustomerName")]
        [LookupEditor(typeof(CustomerRow), InplaceAdd = true)]
        public Int32? CustomerId
        {
            get { return Fields.CustomerId[this]; }
            set { Fields.CustomerId[this] = value; }
        }

        [DisplayName("Order Date"), NotNull, QuickFilter]
        public DateTime? OrderDate
        {
            get { return Fields.OrderDate[this]; }
            set { Fields.OrderDate[this] = value; }
        }

        [DisplayName("Deadline Date"), NotNull]
        public DateTime? DeadlineDate
        {
            get { return Fields.DeadlineDate[this]; }
            set { Fields.DeadlineDate[this] = value; }
        }

        [DisplayName("Shipped Date")]
        public DateTime? ShippedDate
        {
            get { return Fields.ShippedDate[this]; }
            set { Fields.ShippedDate[this] = value; }
        }

        [DisplayName("Ship Address"), Size(200), NotNull, QuickSearch]
        public String ShipAddress
        {
            get { return Fields.ShipAddress[this]; }
            set { Fields.ShipAddress[this] = value; }
        }

        [DisplayName("Customer Name"), Expression("jCustomer.[Name]"), QuickSearch]
        public String CustomerName
        {
            get { return Fields.CustomerName[this]; }
            set { Fields.CustomerName[this] = value; }
        }

        [DisplayName("Customer Email"), Expression("jCustomer.[Email]")]
        public String CustomerEmail
        {
            get { return Fields.CustomerEmail[this]; }
            set { Fields.CustomerEmail[this] = value; }
        }

        [DisplayName("Customer Phone"), Expression("jCustomer.[Phone]")]
        public String CustomerPhone
        {
            get { return Fields.CustomerPhone[this]; }
            set { Fields.CustomerPhone[this] = value; }
        }

        [DisplayName("Customer Address"), Expression("jCustomer.[Address]")]
        public String CustomerAddress
        {
            get { return Fields.CustomerAddress[this]; }
            set { Fields.CustomerAddress[this] = value; }
        }

        [DisplayName("Customer Gender"), Expression("jCustomer.[Gender]")]
        public Int32? CustomerGender
        {
            get { return Fields.CustomerGender[this]; }
            set { Fields.CustomerGender[this] = value; }
        }

        [DisplayName("Customer Date Of Birth"), Expression("jCustomer.[DateOfBirth]")]
        public DateTime? CustomerDateOfBirth
        {
            get { return Fields.CustomerDateOfBirth[this]; }
            set { Fields.CustomerDateOfBirth[this] = value; }
        }

        [DisplayName("Customer Notes"), Expression("jCustomer.[Notes]")]
        public String CustomerNotes
        {
            get { return Fields.CustomerNotes[this]; }
            set { Fields.CustomerNotes[this] = value; }
        }

        [DisplayName("Details List"), NotMapped]
        [MasterDetailRelation(foreignKey: "OrderId", IncludeColumns = "ProductName, TotalPrice, TotalItbis, ProductUnitPrice, ProductItbis")]
        public List<OrderDetailRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }

        [DisplayName("Order Status"), QuickFilter]
        [Expression("(CASE " +
            "WHEN T0.[ShippedDate] IS NULL THEN " +
                "(CASE WHEN GETDATE() > T0.[DeadlineDate] THEN 4 ELSE 2 END) " + 
            "WHEN T0.[ShippedDate] > T0.[DeadlineDate] THEN 3 " + 
            "ELSE 1 END)")
        ]
        public OrderStatus? OrderStatus
        {
            get { return (OrderStatus?)Fields.OrderStatus[this]; }
            set { Fields.OrderStatus[this] = (Int32?)value; }
        }

        public Int32Field CustomerIdField
        {
            get { return Fields.CustomerId; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.OrderId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ShipAddress; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OrderRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderId;
            public Int32Field CustomerId;
            public DateTimeField OrderDate;
            public DateTimeField DeadlineDate;
            public DateTimeField ShippedDate;
            public StringField ShipAddress;

            public StringField CustomerName;
            public StringField CustomerEmail;
            public StringField CustomerPhone;
            public StringField CustomerAddress;
            public Int32Field CustomerGender;
            public DateTimeField CustomerDateOfBirth;
            public StringField CustomerNotes;

            public Int32Field OrderStatus;
            public RowListField<OrderDetailRow> DetailList;
        }
    }
}
