namespace K19_K32_Cap5_K19.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLivro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        LivroID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Preco = c.Double(nullable: false),
                        EditoraID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LivroID)
                .ForeignKey("dbo.Editoras", t => t.EditoraID, cascadeDelete: true)
                .Index(t => t.EditoraID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Livroes", new[] { "EditoraID" });
            DropForeignKey("dbo.Livroes", "EditoraID", "dbo.Editoras");
            DropTable("dbo.Livroes");
        }
    }
}
