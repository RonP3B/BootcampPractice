using FluentMigrator;
using System;

namespace SportShop.Migrations.SportStoreDB
{
    [Migration(20240331120000)]
    public class SportStoreDB_20240331_120000_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Product", "ProductId", s => s
               .WithColumn("Name").AsString(100).NotNullable()
               .WithColumn("Description").AsString(200).NotNullable()
               .WithColumn("UnitPrice").AsCurrency().NotNullable()
               .WithColumn("UnitsInStock").AsInt32().NotNullable()
               .WithColumn("Brand").AsString(200).Nullable()
               .WithColumn("Weight").AsDecimal().NotNullable()
               .WithColumn("ITBIS").AsDecimal().NotNullable()
            );

            this.CreateTableWithId32("Customer", "CustomerId", s => s
               .WithColumn("Name").AsString(100).NotNullable()
               .WithColumn("Email").AsString(200).NotNullable().Unique("UQ_CustomerEmail")
               .WithColumn("Phone").AsString(20).NotNullable().Unique("UQ_CustomerPhone")
               .WithColumn("Address").AsString(200).NotNullable().Unique("UQ_CustomerAddress")
               .WithColumn("Gender").AsInt32().NotNullable().WithDefaultValue(1)
               .WithColumn("DateOfBirth").AsDateTime().NotNullable()
               .WithColumn("Notes").AsString(350).Nullable()
             );

            this.CreateTableWithId32("Order", "OrderId", s => s
                .WithColumn("CustomerId").AsInt32().NotNullable()
                    .ForeignKey("FK_Order_CustomerId", "Customer", "CustomerId")
                .WithColumn("OrderDate").AsDateTime().NotNullable()
                .WithColumn("DeadlineDate").AsDateTime().NotNullable()
                .WithColumn("ShippedDate").AsDateTime().Nullable()
                .WithColumn("ShipAddress").AsString(200).NotNullable()
            );

            this.CreateTableWithId32("OrderDetail", "OrderDetailId", s => s
                .WithColumn("OrderId").AsInt32().NotNullable()
                    .ForeignKey("FK_OrderDetail_OrderId", "Order", "OrderId")
                .WithColumn("ProductId").AsInt32().NotNullable()
                    .ForeignKey("FK_OrderDetail_ProductId", "Product", "ProductId")
                .WithColumn("UnitPrice").AsCurrency().NotNullable()
                .WithColumn("ITBIS").AsDecimal().NotNullable()
                .WithColumn("Quantity").AsDecimal().NotNullable()
            );
        }
    }
}