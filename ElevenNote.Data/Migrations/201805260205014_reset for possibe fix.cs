namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resetforpossibefix : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Note", "IsStarred");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "IsStarred", c => c.Boolean(nullable: false));
        }
    }
}
