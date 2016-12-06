using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace TestThisSerene.MovieDB
{
    public partial class PersonEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "TestThisSerene.MovieDB.PersonEditor";

        public PersonEditorAttribute()
            : base(Key)
        {
        }
    }
}

