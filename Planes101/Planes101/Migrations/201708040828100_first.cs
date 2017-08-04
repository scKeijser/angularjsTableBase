namespace Planes101.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartLoc = c.String(),
                        EndLoc = c.Int(nullable: false),
                        Plane_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Planes", t => t.Plane_ID)
                .Index(t => t.Plane_ID);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OnFlight_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Flights", t => t.OnFlight_ID)
                .Index(t => t.OnFlight_ID);
            
            CreateTable(
                "dbo.Planes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Flights", "Plane_ID", "dbo.Planes");
            DropForeignKey("dbo.Passengers", "OnFlight_ID", "dbo.Flights");
            DropIndex("dbo.Passengers", new[] { "OnFlight_ID" });
            DropIndex("dbo.Flights", new[] { "Plane_ID" });
            DropTable("dbo.Planes");
            DropTable("dbo.Passengers");
            DropTable("dbo.Flights");
        }
    }
}
