namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableInviteState : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InviteStates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        State = c.String(),
                        DateSend = c.DateTime(nullable: false),
                        DateResponse = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InviteStates");
        }
    }
}
