namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction
    {
        [Key]
        public int Transaction_Id { get; set; }

        [StringLength(20)]
        public string Reference_No { get; set; }

        [StringLength(15)]
        public string Mobile_No { get; set; }

        public int? Entity_Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? Txn_Amt { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(500)]
        public string Website { get; set; }

        [StringLength(500)]
        public string Callback_Url { get; set; }

        [StringLength(500)]
        public string Response { get; set; }
    }
}
