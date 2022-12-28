using System;

namespace AutoGermanaBackEnd.DTOs
{
    public class ProductInDTO
    {
        public Guid? idProducto { get; set; }

        public Guid idCategoria { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public string? descripcion { get; set; }
        public bool? estado { get; set; }


    }
}
