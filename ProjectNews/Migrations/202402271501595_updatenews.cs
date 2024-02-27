namespace ProjectNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatenews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_News", "NewsCategoryId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_News", "NewsCategoryId");
        }
    }
}
