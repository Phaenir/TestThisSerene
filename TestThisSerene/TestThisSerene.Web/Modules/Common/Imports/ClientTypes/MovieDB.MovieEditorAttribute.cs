using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace TestThisSerene.MovieDB
{
    public partial class MovieEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "TestThisSerene.MovieDB.MovieEditor";

        public MovieEditorAttribute()
            : base(Key)
        {
        }
    }
}

