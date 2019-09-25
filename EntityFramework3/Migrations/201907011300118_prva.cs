namespace EntityFramework3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prva : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Djelatniks", "OIB", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Djelatniks", "OIB");
        }
    }
}
