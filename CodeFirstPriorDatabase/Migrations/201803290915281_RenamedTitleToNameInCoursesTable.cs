namespace CodeFirstPriorDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedTitleToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            Sql("update Courses set Name = Title");
            DropColumn("dbo.Courses", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            Sql("update Courses set Title = Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
