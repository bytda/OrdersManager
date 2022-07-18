using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Models
{
    public class Order
    {
        [Display(Name = "Номер заказа")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Город отправителя")]
        [StringLength(60, MinimumLength = 3)]
        public string StartCity { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Адрес Отправителя")]
        [StringLength(60, MinimumLength = 3)]
        public string StartAdress { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Город получателя")]
        [StringLength(60, MinimumLength = 3)]
        public string FinishCity { get; set; } = string.Empty;


        [Required]
        [Display(Name = "Адрес получателя")]
        [StringLength(60, MinimumLength = 3)]
        public string FinishAdress{ get; set; } = string.Empty;

        [Range(1, 100000)]
        [Display(Name = "Вес груза, г")]
        public int Weight { get; set; }

        [Display(Name = "Дата забора груза")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

     

    }
}

