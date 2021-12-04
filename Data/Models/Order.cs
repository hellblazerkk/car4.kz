using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace car4.kz.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        
        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage ="Длина имени не более 25 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина фамилии не более 15 символов")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина адреса не более 15 символов")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина номера не более 20 символов")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Длина email не более 30 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
