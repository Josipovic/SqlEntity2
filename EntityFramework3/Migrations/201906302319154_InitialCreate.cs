namespace EntityFramework3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetaljiZaposlenikas",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Placa = c.Single(nullable: false),
                        Adresa = c.String(),
                        Telefon = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Djelatniks", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Djelatniks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetaljiZaposlenikas", "Id", "dbo.Djelatniks");
            DropIndex("dbo.DetaljiZaposlenikas", new[] { "Id" });
            DropTable("dbo.Djelatniks");
            DropTable("dbo.DetaljiZaposlenikas");
        }
    }
}
