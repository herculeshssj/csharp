namespace K19_K32_Cap3_K19EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePluralizing : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alunoes", newName: "Aluno");
            RenameTable(name: "dbo.Professors", newName: "Professor");
            RenameTable(name: "dbo.Turmas", newName: "Turma");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Turma", newName: "Turmas");
            RenameTable(name: "dbo.Professor", newName: "Professors");
            RenameTable(name: "dbo.Aluno", newName: "Alunoes");
        }
    }
}
