namespace nuTestBorje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UrlModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ActuallUrl = c.String(),
                        description = c.String(),
                        UploadDate = c.DateTime(nullable: false),
                        Placing = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UrlModels");
        }
    }
}
