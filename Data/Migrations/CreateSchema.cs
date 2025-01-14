using FluentMigrator;
using Microsoft.OpenApi.Services;

namespace Sports_Web.Data.Migrations
{
    [Migration(14012025)]
    public class CreateSchema:Migration
    {

        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("sports")
                 .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("Name").AsString(120).NotNullable()
                 .WithColumn("GameTime").AsDouble().NotNullable()
                 .WithColumn("Date").AsDate().NotNullable()
                 .WithColumn("NrPlayers").AsInt32().NotNullable();







        }



    }
}
