using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3_Upg1_ContosoBooks.Models
{
    public class Author
    {
        [ScaffoldColumn(false)]
        public int AuthorId { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
