namespace PremiereApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Subscribers", "Name", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subscribers", "Name", c => c.String());
        }
    }
}
