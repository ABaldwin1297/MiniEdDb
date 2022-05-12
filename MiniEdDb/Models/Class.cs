using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiniEdDb.Models {
    [Table("Classes")]

    [Index(nameof(Code), IsUnique = true)]
    public class Class {
        public int Id { get; set; }
        [StringLength(6)]
        public string Code { get; set; }
        [StringLength(30)]
        public string Subject { get; set; }
        public int Section { get; set; }
        public virtual Instructor Instructor { get; set; } = null!;
        public int? InstructorId { get; set; }
    }
}
