using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upteka.BLL.DTOObjects
{
    [DisplayName("Продукт")]
    public class ProductDTO
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Штрих-код")]
        public string BarCode { get; set; }

        [DisplayName("Количество в наличии")]
        public int InStock { get; set; }
    }
}
