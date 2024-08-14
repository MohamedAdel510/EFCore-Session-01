using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Entities
{
    public class Employee02
    {

        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }
        //[Column(TypeName = "Money")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Range(22, 50)]
        public int? Age { get; set; }
    }
}
