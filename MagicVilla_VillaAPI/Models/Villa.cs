using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Models
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // this will auto generate new id number for every insertion
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; } 
        public double Rate { get; set; }
        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
        public DateTime CreatedDate { get; set; } // we should not expose this so this will not be present in DTO
        public DateTime UpdatedDate { get; set;}
    }
}
