namespace K19_K32_Cap5_K19.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Editoras",
                c => new
                    {
                        EditoraID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.EditoraID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Editoras");
        }
    }
}
