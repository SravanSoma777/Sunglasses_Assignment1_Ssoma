using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sunglasses_Assignment1_Ssoma.Models
{
    public class Sunglasses
    {
        public int Id { get; set; }
        public string name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string ShadeType { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string review { get; set; }
        public int reviewScale { get; set; }
        public string country { get; set; }
    }
}
