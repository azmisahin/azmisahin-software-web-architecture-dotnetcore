using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web
{
    public class Customer
    {        
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Required, StringLength(50)]     
        public string Name { get; set; }
    }
}