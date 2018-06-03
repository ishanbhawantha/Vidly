namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedateofbirth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Customers", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DateTime", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
