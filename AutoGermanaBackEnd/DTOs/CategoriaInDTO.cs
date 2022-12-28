using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.DTOs
{
    public class CategoriaInDTO
    {
        public Guid? idCategoria { get; set; }
        public string nombre { get; set; }
        public string? descripcion { get; set; }
        public bool estado { get; set; }
    }
}
