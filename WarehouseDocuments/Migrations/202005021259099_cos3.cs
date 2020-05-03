namespace WarehouseDocuments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cos3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleID = c.Int(nullable: false, identity: true),
                        DocumentID = c.Int(nullable: false),
                        ArticleName = c.String(),
                        Quantity = c.Int(nullable: false),
                        NetPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GrossPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ArticleID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerNumber = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerNumber);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        DocumentID = c.Int(nullable: false, identity: true),
                        DocumentDate = c.DateTime(nullable: false),
                        CustomerNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DocumentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Documents");
            DropTable("dbo.Customers");
            DropTable("dbo.Articles");
        }
    }
}
