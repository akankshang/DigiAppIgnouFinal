namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Question_Id { get; set; }

        public int? Asked_By { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public string Description { get; set; }

        public int? Selected_Answer { get; set; }

        public DateTime? DTS { get; set; }
    }
}
