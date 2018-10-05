namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Quizes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Quiz_Group_Id { get; set; }

        [StringLength(50)]
        public string Quiz_Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}
