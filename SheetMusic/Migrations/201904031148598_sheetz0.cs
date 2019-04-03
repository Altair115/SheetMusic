namespace SheetMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sheetz0 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pieces", "Artist", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pieces", "Artist");
        }
    }
}
