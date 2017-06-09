using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnotherFuckngProject.Models
{
    public class Task : BaseModel
    {
        public string Title { get; set; }
        public int UserID { get; set; }
    }
}