using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace TestThisSerene.Modules.Common.Migrations.DefaultDB
{
    [Migration(20161122145100)]
    public class DefaultDB_20161122_145100_GenreTable : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("Genre").InSchema("mov")
                .WithColumn("GenreId").AsInt32().NotNullable()
                .PrimaryKey().Identity()
                .WithColumn("Name").AsString(100).NotNullable();
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("GenreId").AsInt32().Nullable()
                .ForeignKey("FK_Movie_GenreId", "mov", "Genre", "GenreId");
        }
    }
}