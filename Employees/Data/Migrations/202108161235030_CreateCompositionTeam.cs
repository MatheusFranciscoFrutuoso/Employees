namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCompositionTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Team_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Team_Id");
            AddForeignKey("dbo.Employees", "Team_Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Employees", new[] { "Team_Id" });
            DropColumn("dbo.Employees", "Team_Id");
        }
    }
}
