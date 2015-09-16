namespace PremiereApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.SubscriberCategories",
                c => new
                    {
                        Subscriber_SubscriberId = c.Int(nullable: false),
                        Category_CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subscriber_SubscriberId, t.Category_CategoryId })
                .ForeignKey("dbo.Subscribers", t => t.Subscriber_SubscriberId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId, cascadeDelete: true)
                .Index(t => t.Subscriber_SubscriberId)
                .Index(t => t.Category_CategoryId);
            
            AddColumn("dbo.Subscribers", "CreationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubscriberCategories", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.SubscriberCategories", "Subscriber_SubscriberId", "dbo.Subscribers");
            DropIndex("dbo.SubscriberCategories", new[] { "Category_CategoryId" });
            DropIndex("dbo.SubscriberCategories", new[] { "Subscriber_SubscriberId" });
            DropColumn("dbo.Subscribers", "CreationDate");
            DropTable("dbo.SubscriberCategories");
            DropTable("dbo.Categories");
        }
    }
}
