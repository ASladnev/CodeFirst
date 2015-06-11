namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonCompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "LastName", c => c.String());
            AlterColumn("dbo.People", "FirstName", c => c.String());
            DropTable("dbo.Companies");
        }
    }
}
