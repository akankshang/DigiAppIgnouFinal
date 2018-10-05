namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Course_Id { get; set; }

        public int? Course_Type { get; set; }

        [StringLength(250)]
        public string SortDescription { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public int? Rating { get; set; }

        [StringLength(500)]
        public string Schedule { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(500)]
        public string ImagePath { get; set; }
    }
}
