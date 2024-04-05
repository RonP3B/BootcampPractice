
namespace SportShop.SportStore.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("SportStore"), Module("SportStore"), TableName("[dbo].[Customer]")]
    [DisplayName("Customers"), InstanceName("Customer")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("SportStore.Customer", Permission = "SportStore:General")]
    public sealed class CustomerRow : Row, IIdRow, INameRow
    {
        [DisplayName("Customer Id"), Identity]
        public Int32? CustomerId
        {
            get { return Fields.CustomerId[this]; }
            set { Fields.CustomerId[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Email"), Size(200), NotNull, Unique]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Phone"), Size(20), NotNull, Unique]
        public String Phone
        {
            get { return Fields.Phone[this]; }
            set { Fields.Phone[this] = value; }
        }

        [DisplayName("Address"), Size(200), NotNull, Unique]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Gender"), NotNull]
        public CustomerGender? Gender
        {
            get { return (CustomerGender?)Fields.Gender[this]; }
            set { Fields.Gender[this] = (Int32)value; }
        }

        [DisplayName("Date Of Birth"), NotNull]
        public DateTime? DateOfBirth
        {
            get { return Fields.DateOfBirth[this]; }
            set { Fields.DateOfBirth[this] = value; }
        }

        [DisplayName("Notes"), Size(350)]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CustomerId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomerRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CustomerId;
            public StringField Name;
            public StringField Email;
            public StringField Phone;
            public StringField Address;
            public Int32Field Gender;
            public DateTimeField DateOfBirth;
            public StringField Notes;
        }
    }
}
