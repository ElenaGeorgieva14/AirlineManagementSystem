namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlightNumber = c.String(nullable: false),
                        BoardingTime = c.DateTime(nullable: false),
                        NumberOfSeats = c.Int(nullable: false),
                        From = c.String(nullable: false),
                        To = c.String(nullable: false),
                        Gate = c.Int(nullable: false),
                        TicketPrice = c.Double(nullable: false),
                        PilotId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.PilotId, cascadeDelete: true)
                .Index(t => t.PilotId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Job = c.String(nullable: false),
                        BirthDate = c.DateTime(),
                        Salary = c.Double(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FlightId = c.Int(nullable: false),
                        DocumentNumber = c.String(nullable: false),
                        Nationality = c.String(nullable: false),
                        SeatNumber = c.String(),
                        Class = c.String(nullable: false),
                        Luggage = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .Index(t => t.FlightId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Flights", "PilotId", "dbo.Users");
            DropIndex("dbo.Tickets", new[] { "FlightId" });
            DropIndex("dbo.Flights", new[] { "PilotId" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Users");
            DropTable("dbo.Flights");
        }
    }
}
