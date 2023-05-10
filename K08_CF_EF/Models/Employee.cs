using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace K08_CF_EF.Models
{
    public class Employee
    {
        // DB tarafında tutacağım tablonun yapısını gösteren/içeren bir class.
        [Key] // EmpId alanının anahtar alan olduğunu belirtiyor.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // DB tarafındaki Identity belirtimi
        public int EmpId { get; set; }
        [Required] // Bu alanın mutlaka olması gerektiği belirtiyor.
        [Column(TypeName = "nvarchar(20)")]
        public string FName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string LName { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string City { get; set; }
    }
}
