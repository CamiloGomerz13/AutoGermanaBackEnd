using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Models
{
    public class producto
    {
        [Key]
        public Guid idproducto { get; set; }

        [ForeignKey("categoria")]
        public Guid idcategoria { get; set; }

        [MaxLength(64)]
        public string codigo { get; set; }

        [Required]
        [MaxLength(100)]
        public string nombre { get; set; }
        
        [Required]
        [Range(11,2)]
        public decimal precio_venta { get; set; }

        [Required]
        public int stock { get; set; }

        [MaxLength(255)]
        public string descripcion { get; set; }
        public Byte[] imagen { get; set; }

        [DefaultValue(true)]
        public bool estado { get; set; }

        public virtual categoria Categoria { get; set; }

    }
}
