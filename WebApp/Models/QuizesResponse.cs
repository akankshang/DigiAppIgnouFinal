namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuizesResponse")]
    public partial class QuizesResponse
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Quiz_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Question_Id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string Quiz_No { get; set; }

        public int? Response { get; set; }

        public DateTime? DTS { get; set; }
    }
}
