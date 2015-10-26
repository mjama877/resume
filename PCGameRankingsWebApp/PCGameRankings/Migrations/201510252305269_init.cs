namespace PCGameRankings.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PCGames",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        GameTitle = c.String(maxLength:100),
                        ImageURL = c.String(maxLength:150),
                        Rank = c.String(maxLength:3),
                        ReleaseDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.GameID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PCGames");
        }
    }
}
