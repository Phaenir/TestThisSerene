using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestThisSerene.MovieDB
{
    using Serenity.Services;
    
    public class MovieListRequest:ListRequest
    {
        public List<int> Genres { get; set; }
    }
}