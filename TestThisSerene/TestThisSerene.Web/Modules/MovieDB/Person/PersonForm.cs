
namespace TestThisSerene.MovieDB.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Modules.MovieDB.Person;

    [FormScript("MovieDB.Person")]
    [BasedOnRow(typeof(Entities.PersonRow))]
    public class PersonForm
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String FullName { get; set; }
        public DateTime Birthdate { get; set; }
        
        public String BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public Int32 Height { get; set; }
    }
}