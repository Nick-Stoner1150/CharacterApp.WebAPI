namespace CharacterApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Character", "TeamId", "dbo.Team");
            DropIndex("dbo.Character", new[] { "TeamId" });
            AlterColumn("dbo.Character", "TeamId", c => c.Int(nullable: false));
            CreateIndex("dbo.Character", "TeamId");
            AddForeignKey("dbo.Character", "TeamId", "dbo.Team", "TeamId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Character", "TeamId", "dbo.Team");
            DropIndex("dbo.Character", new[] { "TeamId" });
            AlterColumn("dbo.Character", "TeamId", c => c.Int());
            CreateIndex("dbo.Character", "TeamId");
            AddForeignKey("dbo.Character", "TeamId", "dbo.Team", "TeamId");
        }
    }
}
