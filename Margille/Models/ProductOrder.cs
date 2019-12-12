using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class ProductOrder
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductQtd { get; set; }
        /*O valor 0-zero indica o valor do atributo, o qual vai ter a formatação F2, 
            a qual é a formatação que define que serão exibidas duas casas decimais*/
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double OrderProductPrice { get; set; }
    }
}
