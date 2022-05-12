using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiniEdDb.Models {
    public class Instructor {
        public int Id { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; } = null!;
        [StringLength(30)]
        public string LastName { get; set; } = null!;
        public int YearsExperience { get; set; }
        public bool IsTenured { get; set; }

       //public override string ToString() {
           //return $"{Id,5} {FirstName,-30} {LastName,-30} {YearsExperience,5} {IsTenured}";
        //}
    }
}
