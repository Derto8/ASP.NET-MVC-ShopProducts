using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MagazineShop.Models
{
    public class AddProduct
    {
        [BindNever]
        public string Id { get; set; }

        [Display(Name = "Введите название товара")]
        [StringLength(40)]
        [Required(ErrorMessage = "Длина названия товара не более 40 символов!")]
        public string Name { get; set; }

        [Display(Name = "Введите цену за товар")]
        public double Price { get; set; }

        [Display(Name = "Введите название компании производителя")]
        [StringLength(40)]
        [Required(ErrorMessage = "Длина названия компании не более 40 символов!")]
        public string Manufacturer { get; set; }

        [Display(Name = "Введите адрес к изображению")]
        [StringLength(100)]
        [Required(ErrorMessage = "Длина адреса картинки не более 100 символов!")]
        public string Img { get; set; }
        [Display(Name = "Введите категорию товара")]
        public string Class { get; set; }
    }
}
