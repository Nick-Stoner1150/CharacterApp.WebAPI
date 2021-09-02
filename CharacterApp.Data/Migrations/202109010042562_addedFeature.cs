namespace CharacterApp.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class addedFeature : DbMigration

    public partial class addedeFeature : DbMigration
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
                })
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
            
                .PrimaryKey(t => t.Id);

            DropForeignKey("dbo.Feature", "Character_CharacterId", "dbo.Character");

            DropTable("dbo.Feature");
        }
    }
}
