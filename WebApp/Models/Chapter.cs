namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Chapter
    {
        [Key]
        public int Chapter_Id { get; set; }

        public int? Course_Id { get; set; }

        [StringLength(250)]
        public string Chapter_Title { get; set; }

        public string Description { get; set; }

        [StringLength(500)]
        public string Schedule { get; set; }

        public int? Author { get; set; }

        public DateTime? DTS { get; set; }

          
    }
}
