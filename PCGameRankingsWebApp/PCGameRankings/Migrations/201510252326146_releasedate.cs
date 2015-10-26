namespace PCGameRankings.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class releasedate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PCGames", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PCGames", "ReleaseDate", c => c.String());
        }
    }
}
