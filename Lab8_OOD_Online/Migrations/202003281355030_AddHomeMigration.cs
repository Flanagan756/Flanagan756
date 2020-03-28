namespace Lab8_OOD_Online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHomeMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "HomeGround", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "HomeGround");
        }
    }
}
