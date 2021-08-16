namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCompositionEmployees : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Inv_State_Id", c => c.Int());
            AddColumn("dbo.Employees", "Position_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Inv_State_Id");
            CreateIndex("dbo.Employees", "Position_Id");
            AddForeignKey("dbo.Employees", "Inv_State_Id", "dbo.InviteStates", "Id");
            AddForeignKey("dbo.Employees", "Position_Id", "dbo.Positions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Position_Id", "dbo.Positions");
            DropForeignKey("dbo.Employees", "Inv_State_Id", "dbo.InviteStates");
            DropIndex("dbo.Employees", new[] { "Position_Id" });
            DropIndex("dbo.Employees", new[] { "Inv_State_Id" });
            DropColumn("dbo.Employees", "Position_Id");
            DropColumn("dbo.Employees", "Inv_State_Id");
        }
    }
}
