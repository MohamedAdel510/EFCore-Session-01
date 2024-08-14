using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    //EFCore support 4 wayes for mapping class to database [Table / View]
    // 1- By Convention [Default Behaviour]
    // Note: Entity = Class = Model
    // Note: Poco class [Plan Old Clr Object] class that have only properties
    public class Employee
    {
        [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // (1, 1)
        public int EmpId { get; set; }
        // Public Numeric named as (Id || EmployeeId) ==> Set as primary key
        // with identity Constrant (1, 1)
        [Required]
        [Column(TypeName = "varchar")] // => varchar(max)
        [MaxLength(50)] // => varchar(50)
        public string? Name { get; set; }// reference Type Allow Null => [Optional] .net 5.0
        // Referece Type not allow null = > [Required] .net 6.0
        // Nullable (allow null) => [Optional] .net 6.0
        // of Type => nvarchar(max)
        
        [Column(TypeName = "Money")]
        //[DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        // Value Type not allow null => [Required]
        // => decimal(18,2)
        [Range(22, 60)]
        public int? Age { get; set; }
        // Value Type Nullable => [Optional]
        // int
        
        [EmailAddress]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Phone]
        //[DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
