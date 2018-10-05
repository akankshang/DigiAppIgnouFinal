namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QuizesOption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Question_Id { get; set; }

        [StringLength(500)]
        public string OptionValue { get; set; }

        public bool? Is_Corrrect { get; set; }

        public int? Author { get; set; }

        public DateTime? DTS { get; set; }
    }
}
