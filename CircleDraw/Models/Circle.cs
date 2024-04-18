using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CircleDraw.Models
{
    public class Circle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public float Diameter { get; set; }

        public String Color { get; set; }

        public DateTime TimeOfSubmission { get; set; }

        public int SetId { get; set; }


    }
}
