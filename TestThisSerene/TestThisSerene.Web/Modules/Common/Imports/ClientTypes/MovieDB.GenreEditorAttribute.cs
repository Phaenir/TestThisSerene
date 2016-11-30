using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace TestThisSerene.MovieDB
{
    public partial class GenreEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "TestThisSerene.MovieDB.GenreEditor";

        public GenreEditorAttribute()
            : base(Key)
        {
        }
    }
}

