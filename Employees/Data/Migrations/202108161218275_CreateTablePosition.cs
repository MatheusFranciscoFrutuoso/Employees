namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePosition : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcessLevel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.AcessLevel_Id)
                .Index(t => t.AcessLevel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Positions", "AcessLevel_Id", "dbo.Profiles");
            DropIndex("dbo.Positions", new[] { "AcessLevel_Id" });
            DropTable("dbo.Positions");
        }
    }
}
