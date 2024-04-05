using FluentMigrator;
using System;

namespace SportShop.Migrations.SportStoreDB
{
    [Migration(20240401000000)]
    public class SportStoreDB_20240401_000000_ItbisAndPriceRemoved : Migration
    {
        public override void Up()
        {
            Delete.Column("ITBIS").FromTable("OrderDetail");
            Delete.Column("UnitPrice").FromTable("OrderDetail");
        }

        public override void Down() { }
    }
}