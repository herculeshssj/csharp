namespace K19_K32_Cap3_K19EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Annotations : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Aluno", newName: "tbl_aluno");
            RenameTable(name: "dbo.Professor", newName: "tbl_professor");
            RenameTable(name: "dbo.Turma", newName: "tbl_turma");
            AlterColumn("dbo.tbl_aluno", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.tbl_professor", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_professor", "Nome", c => c.String());
            AlterColumn("dbo.tbl_aluno", "Nome", c => c.String());
            RenameTable(name: "dbo.tbl_turma", newName: "Turma");
            RenameTable(name: "dbo.tbl_professor", newName: "Professor");
            RenameTable(name: "dbo.tbl_aluno", newName: "Aluno");
        }
    }
}
