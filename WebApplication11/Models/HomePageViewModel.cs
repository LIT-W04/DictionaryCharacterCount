using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class HomePageViewModel
    {
        public Dictionary<char, int> CharacterCounts { get; set; }
        public string Text { get; set; }
    }
}