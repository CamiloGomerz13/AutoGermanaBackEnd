using System;

namespace AutoGermanaBackEnd.DTOs
{
    public class ProductInDTO
    {
        public Guid? idproducto { get; set; }

        public Guid idcategoria { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public decimal precio_venta { get; set; }
        public int stock { get; set; }
        public string? descripcion { get; set; }
        public bool? estado { get; set; }


    }
}
