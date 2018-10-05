namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Enrollment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Entity_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Course_Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fees { get; set; }

        public DateTime? Opted_Date { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Reference_No { get; set; }

        [StringLength(50)]
        public string Paid_By { get; set; }

        public DateTime? DTS { get; set; }
    }
}
