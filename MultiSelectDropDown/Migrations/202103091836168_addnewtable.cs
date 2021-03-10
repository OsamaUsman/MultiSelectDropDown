namespace MultiSelectDropDown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SelectedCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AllCustomers = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SelectedCustomers");
        }
    }
}
