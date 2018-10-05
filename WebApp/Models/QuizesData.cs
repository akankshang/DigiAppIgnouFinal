namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuizesData")]
    public partial class QuizesData
    {
        [Key]
        [StringLength(25)]
        public string Quiz_No { get; set; }

        public int? Entity_Id { get; set; }

        public DateTime? Start_Date { get; set; }

        public DateTime? End_Date { get; set; }

        [StringLength(15)]
        public string IP { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        public DateTime? DTS { get; set; }
    }
}
