using FluentMigrator;

namespace SportShop.Migrations.DefaultDB
{
    [Migration(20240403072600)]
    public class DefaultDB_20240403_072600_CustomerId : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Users").AddColumn("CustomerId").AsInt32().Nullable();
        }
    }
}