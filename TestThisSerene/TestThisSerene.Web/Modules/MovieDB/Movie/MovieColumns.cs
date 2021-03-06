﻿
namespace TestThisSerene.MovieDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String Description { get; set; }
        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        [DisplayName("Release Date"), Width(200), AlignRight]
        public DateTime ReleaseDate { get; set; }
        /*
        [Width(100), QuickFilter]
        public String GenreName { get; set; }
        */
        [Width(200), GenreListFormatter, QuickFilter]
        public List<Int32> GenreList { get; set; }

        [DisplayName("Runtime in Minutes"), Width(150),AlignRight]
        public Int32 Runtime { get; set; }
        [DisplayName("Kind"), Width(150), AlignRight]
        public MovieKind? Kind { get; set; }
    }
}