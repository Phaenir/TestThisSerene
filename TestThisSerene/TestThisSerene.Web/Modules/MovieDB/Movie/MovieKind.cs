using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace TestThisSerene.MovieDB
{
    [EnumKey("MovieDB.MovieKind")]
    public enum MovieKind
    {
        [Description("Film")]
        Film=1,
        [Description("TV Series")]
        TvSeries=2,
        [Description("Mini Series")]
        MiniSeries=3
    }
}