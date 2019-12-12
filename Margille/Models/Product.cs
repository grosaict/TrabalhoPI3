using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        /*O valor 0-zero indica o valor do atributo, o qual vai ter a formatação F2, 
        * a qual é a formatação que define que serão exibidas duas casas decimais*/
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double ProductPrice { get; set; }

        // O atributo abaixo serve para realizar o vículo n para n em MargilleContext.cs
        public List<ProductOrder> ProductOrders { get; set; }

    }
}
