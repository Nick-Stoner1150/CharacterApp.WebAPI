namespace CharacterApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
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
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Feature");
        }
    }
}
