using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upteka.BLL.DTOObjects
{
    [DisplayName("Продукт")]
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Название")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\d+", ErrorMessage = "Штрих-код должен состоять только из цифр")]
        [StringLength(13, MinimumLength = 8, ErrorMessage = "Длинна штрих-кода должна быть от 8 до 13 цифр")]
        [DisplayName("Штрих-код")]
        public string BarCode { get; set; }

        [Required]
        [DisplayName("Количество в наличии")]
        public int InStock { get; set; }
    }
}
