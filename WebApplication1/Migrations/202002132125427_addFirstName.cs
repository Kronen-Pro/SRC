namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFirstName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "BirthDay", c => c.DateTime(nullable: true));
            AlterColumn("dbo.AspNetUsers", "Zip", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Zip", c => c.String());
            AlterColumn("dbo.AspNetUsers", "BirthDay", c => c.String());
        }
    }
}
