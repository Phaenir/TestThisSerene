using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestThisSerene.Modules.Common.Migrations.DefaultDB
{
    [FluentMigrator.Migration(20161121152600)]
    public class DefaultDB_20161121_152600_MovieKind : FluentMigrator.Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("Kind").AsInt32().NotNullable()
                .WithDefaultValue(1);
        }
    }
}