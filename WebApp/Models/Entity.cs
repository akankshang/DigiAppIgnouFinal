namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entity")]
    public partial class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Entity_Id { get; set; }

        [StringLength(50)]
        public string Entity_Name { get; set; }

        [StringLength(6)]
        public string Gender { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? Join_Date { get; set; }

        [StringLength(500)]
        public string Profile_Url { get; set; }

        [StringLength(10)]
        public string Entity_Type { get; set; }

        public int? Rating { get; set; }

        public int? Views { get; set; }

        public int? Likes { get; set; }

        public int? Dislikes { get; set; }

        public DateTime? LastActiveDate { get; set; }
    }
}
