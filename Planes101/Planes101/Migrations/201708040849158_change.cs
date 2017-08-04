namespace Planes101.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Flights", "EndLoc", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Flights", "EndLoc", c => c.Int(nullable: false));
        }
    }
}
