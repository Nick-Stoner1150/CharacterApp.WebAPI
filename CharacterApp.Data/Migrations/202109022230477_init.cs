namespace CharacterApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Character", name: "Team_TeamId", newName: "TeamId");
            RenameIndex(table: "dbo.Character", name: "IX_Team_TeamId", newName: "IX_TeamId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Character", name: "IX_TeamId", newName: "IX_Team_TeamId");
            RenameColumn(table: "dbo.Character", name: "TeamId", newName: "Team_TeamId");
        }
    }
}
