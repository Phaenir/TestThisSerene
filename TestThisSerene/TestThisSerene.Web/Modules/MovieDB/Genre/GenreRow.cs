

namespace TestThisSerene.MovieDB.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Genre"), InstanceName("Genre"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class GenreRow : Row, IIdRow, INameRow
    {
        [DisplayName("Genre Id"), Identity]
        public Int32? GenreId
        {
            get { return Fields.GenreId[this]; }
            set { Fields.GenreId[this] = value; }
        }

        [DisplayName("Genre"), Size(100), NotNull, QuickSearch]
        public String Genre
        {
            get { return Fields.Genre[this]; }
            set { Fields.Genre[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.GenreId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Genre; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public GenreRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field GenreId;
            public StringField Genre;

            public RowFields()
                : base("[dbo].[Genre]")
            {
                LocalTextPrefix = "MovieDB.Genre";
            }
        }
    }
}