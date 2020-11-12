using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Wba.RateMovie.Domain.Entities
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto nummering 
        public long Id { get; set; }

        [Required(ErrorMessage="Must have title!")]
        [MaxLength(200)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
    }
}
