namespace FinalProg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categorias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        Categoria = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categorias");
        }
    }
}
