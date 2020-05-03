namespace WarehouseDocuments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    public partial class AddProcedures : DbMigration
    {
        public override void Up()
        {
            var path = "../../Scripts/Procedures.sql";
            string readText = File.ReadAllText(path);
            Sql(readText);   
        }
        
        public override void Down()
        {
        }
    }
}
