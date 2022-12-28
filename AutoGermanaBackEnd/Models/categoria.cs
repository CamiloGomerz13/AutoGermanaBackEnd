using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Models
{
    public class categoria
    {
        [Key]
        public Guid idcategoria { get; set; }

        [Required]
        [MaxLength(50)]
        public string nombre { get; set; }

        [MaxLength(255)]
        public string descripcion { get; set; }

        [DefaultValue(true)]
        public bool estado { get; set; }

        public virtual ICollection<producto> Productos { get; set; }
    }
}
