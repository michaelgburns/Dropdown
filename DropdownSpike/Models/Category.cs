using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DropdownSpike.Models
{
    public enum Category
    {
        [Display(Name = "Science Fiction")]
        ScienceFiction,

        Biography,

        Fiction,

        [Display(Name = "Non fiction")]
        Nonfiction,
    }
}