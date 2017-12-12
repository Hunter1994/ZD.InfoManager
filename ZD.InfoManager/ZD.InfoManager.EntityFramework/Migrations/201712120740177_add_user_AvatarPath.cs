namespace ZD.InfoManager.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_user_AvatarPath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbpUsers", "AvatarPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AbpUsers", "AvatarPath");
        }
    }
}
