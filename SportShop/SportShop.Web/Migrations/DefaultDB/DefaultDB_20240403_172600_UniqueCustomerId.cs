using FluentMigrator;

namespace SportShop.Migrations.DefaultDB
{
    [Migration(20240403172600)]
    public class DefaultDB_20240403_172600_CustomerId : AutoReversingMigration
    {
        public override void Up()
        {
            Create.UniqueConstraint("UQ_DefaultUserCustomerId")
                .OnTable("Users").Columns("CustomerId");
        }
    }
}