using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CodeFirstPriorDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstPriorDatabase.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstPriorDatabase.PlutoContext context)
        {
            context.Authors.AddOrUpdate(a => a.Name,
                new Author
                {
                    Name = "Fred Jones",
                    Courses = new Collection<Course>()
                    {
                        new Course() {Name = "Course 1 from Author 1", Description = "Description"}
                    }
                }
                );
        }
    }
}
