namespace AcuCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrdersToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DrinksId = c.Int(),
                        OptionsId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drinks", t => t.DrinksId)
                .ForeignKey("dbo.Options", t => t.OptionsId)
                .Index(t => t.DrinksId)
                .Index(t => t.OptionsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "OptionsId", "dbo.Options");
            DropForeignKey("dbo.Orders", "DrinksId", "dbo.Drinks");
            DropIndex("dbo.Orders", new[] { "OptionsId" });
            DropIndex("dbo.Orders", new[] { "DrinksId" });
            DropTable("dbo.Orders");
        }
    }
}
