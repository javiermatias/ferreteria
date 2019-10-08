using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entidades
{
    [Table("producto")]
    public class Producto
    {
        //Default Values
        public Producto()
        {
            categoria = "GENERAL";
            estado = true;
            imagen = "Imagenes/default.png";
        }
        [Key]
        public Int64 id { get; set; }

        [Required]
        public string codProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public decimal precioSinIva { get; set; }
        public decimal precioConIva { get; set; }
        public decimal precioVenta { get; set; }
        public int stock { get; set; }            
        public bool estado { get; set; } //false-Inactivo, true-Activo
        
        public string imagen { get; set; }



    


    }

}
