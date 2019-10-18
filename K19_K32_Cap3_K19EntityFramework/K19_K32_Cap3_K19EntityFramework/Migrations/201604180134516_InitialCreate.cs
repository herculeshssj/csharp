namespace K19_K32_Cap3_K19EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        AlunoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco_Logradouro = c.String(),
                        Endereco_Numero = c.Int(nullable: false),
                        Endereco_CEP = c.String(),
                        Turma_TurmaID = c.Int(),
                    })
                .PrimaryKey(t => t.AlunoID)
                .ForeignKey("dbo.Turmas", t => t.Turma_TurmaID)
                .Index(t => t.Turma_TurmaID);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        ProfessorID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco_Logradouro = c.String(),
                        Endereco_Numero = c.Int(nullable: false),
                        Endereco_CEP = c.String(),
                    })
                .PrimaryKey(t => t.ProfessorID);
            
            CreateTable(
                "dbo.Turmas",
                c => new
                    {
                        TurmaID = c.Int(nullable: false, identity: true),
                        Vagas = c.Int(nullable: false),
                        Professor_ProfessorID = c.Int(),
                    })
                .PrimaryKey(t => t.TurmaID)
                .ForeignKey("dbo.Professors", t => t.Professor_ProfessorID)
                .Index(t => t.Professor_ProfessorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turmas", "Professor_ProfessorID", "dbo.Professors");
            DropForeignKey("dbo.Alunoes", "Turma_TurmaID", "dbo.Turmas");
            DropIndex("dbo.Turmas", new[] { "Professor_ProfessorID" });
            DropIndex("dbo.Alunoes", new[] { "Turma_TurmaID" });
            DropTable("dbo.Turmas");
            DropTable("dbo.Professors");
            DropTable("dbo.Alunoes");
        }
    }
}
