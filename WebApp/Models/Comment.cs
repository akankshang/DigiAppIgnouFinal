namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Comment_Id { get; set; }

        public int? Article_Id { get; set; }

        [StringLength(500)]
        public string Body { get; set; }

        public DateTime? CreationDate { get; set; }

        public int? Author { get; set; }

        public bool? Approved { get; set; }

        public bool? Is_Private { get; set; }

        public bool? Is_Editor { get; set; }
    }
}
