using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiniEdDb.Models {

    [Table("ClassGrade")]
    public class ClassGrade {
        public int Id { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal GPA { get; set; }
    }
}
