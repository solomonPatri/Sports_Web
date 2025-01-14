using Sports_Web.Sport;
using FluentMigrator;

namespace Sports_Web.Data.Migrations
{
    [Migration(14112025)]
    public class TestMigrate:Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Execute.Script(@"Data/scripts/data.sql");
        }





    }
}
