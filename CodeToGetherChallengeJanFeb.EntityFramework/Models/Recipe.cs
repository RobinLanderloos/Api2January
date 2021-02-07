using System;
using System.Collections.Generic;
using System.Text;

namespace CodeToGetherChallengeJanFeb.EntityFramework.Models
{
    public class Recipe : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Uri { get; set; }
    }
}
