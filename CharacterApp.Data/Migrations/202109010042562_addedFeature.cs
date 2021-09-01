namespace CharacterApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFeature : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feature",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SuperSpeed = c.String(),
                        Phasing = c.String(),
                        Magic = c.String(),
                        Flight = c.String(),
                        Telepathy = c.String(),
                        Healing = c.String(),
                        Invisibility = c.String(),
                        Character_CharacterId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Character", t => t.Character_CharacterId)
                .Index(t => t.Character_CharacterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feature", "Character_CharacterId", "dbo.Character");
            DropIndex("dbo.Feature", new[] { "Character_CharacterId" });
            DropTable("dbo.Feature");
        }
    }
}
