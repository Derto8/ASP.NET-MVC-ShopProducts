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
        [MinLength(5)]
        [Required(ErrorMessage = "Длина названия товара не менее 5 символов!")]
        public string Name { get; set; }

        [Display(Name = "Введите цену за товар")]
        public double Price { get; set; }


        [Display(Name = "Введите название компании производителя")]
        [MinLength(5)]
        [Required(ErrorMessage = "Длина названия компании не менее 5 символов!")]
        public string Manufacturer { get; set; }

        [Display(Name = "Введите адрес к изображению")]
        [MinLength(5)]
        [Required(ErrorMessage = "Длина адреса картинки не менее 5 символов!")]
        public string Img { get; set; }

        [Display(Name = "Введите категорию товара")]
        [MinLength(1)]
        [Required(ErrorMessage = "Длина категории товара не менее 1 символа!")]
        public string Class { get; set; }
    }
}
