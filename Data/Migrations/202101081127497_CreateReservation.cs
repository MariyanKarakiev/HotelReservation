namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateReservation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameofReservation = c.String(),
                        Age = c.String(),
                        RoomNumber = c.Int(nullable: false),
                        RoomType = c.String(),
                        Smoke = c.Boolean(nullable: false),
                        CalculatedPrice = c.Double(nullable: false),
                        PeriodOfReservation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reservations");
        }
    }
}
