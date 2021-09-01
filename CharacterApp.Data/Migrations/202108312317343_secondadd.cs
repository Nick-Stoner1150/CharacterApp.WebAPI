namespace CharacterApp.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class secondadd : DbMigration
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

        }

        public override void Down()
        {
            DropForeignKey("dbo.Character", "Team_TeamId", "dbo.Team");
            DropIndex("dbo.Character", new[] { "Team_TeamId" });
            DropTable("dbo.Team");
            DropTable("dbo.Character");
        }
    }
}
