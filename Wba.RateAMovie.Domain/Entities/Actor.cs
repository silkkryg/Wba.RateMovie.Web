using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Wba.RateMovie.Domain.Entities
{
    public class Actor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Must have Firstname!")]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Must have Lastname!")]
        [MaxLength(100)]
        public string LastName { get; set; }

    }
}
