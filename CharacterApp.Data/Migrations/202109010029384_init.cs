namespace CharacterApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Character",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        CreatedDate = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedDate = c.DateTimeOffset(precision: 7),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.CharacterId)
                .ForeignKey("dbo.Team", t => t.Team_TeamId)
                .Index(t => t.Team_TeamId);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId);
            
            AddColumn("dbo.Feature", "Character_CharacterId", c => c.Int());
            CreateIndex("dbo.Feature", "Character_CharacterId");
            AddForeignKey("dbo.Feature", "Character_CharacterId", "dbo.Character", "CharacterId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Character", "Team_TeamId", "dbo.Team");
            DropForeignKey("dbo.Feature", "Character_CharacterId", "dbo.Character");
            DropIndex("dbo.Feature", new[] { "Character_CharacterId" });
            DropIndex("dbo.Character", new[] { "Team_TeamId" });
            DropColumn("dbo.Feature", "Character_CharacterId");
            DropTable("dbo.Team");
            DropTable("dbo.Character");
        }
    }
}
