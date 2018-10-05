namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int Cart_Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Reference_No { get; set; }

        public int Entity_Id { get; set; }

        public int Course_Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discount { get; set; }

        public DateTime? Cart_Date { get; set; }

        public bool? Is_Paid { get; set; }

        public DateTime? Payment_Date { get; set; }
    }
}
