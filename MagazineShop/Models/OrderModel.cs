using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace MagazineShop.Models
{
    public class OrderModel
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Введите свое имя!")]
        [MinLength(1)]
        [Required(ErrorMessage = "Длина имени не менее 1 символа!")]
        public string Name { get; set; }
        public string Price { get; set; }

        [Display(Name = "Введите ваш адрес!")]
        [MinLength(5)]
        [Required(ErrorMessage = "Длина адреса не менее 5 символов!")]
        public string Adress { get; set; }

        [Display(Name = "Введите ваш номер телефона!")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(7)]
        [Required(ErrorMessage = "Длина номера телефона не менее 7 символов!")]
        public string Phone { get; set; }

        [Display(Name = "Введите ваш Email!")]
        [DataType(DataType.EmailAddress)]
        [MinLength(5)]
        [Required(ErrorMessage = "Длина почты не менее 5 символов!")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetailModel> OrderDetail { get; set; }
    }
}
