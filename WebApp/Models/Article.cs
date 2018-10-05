namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Article_Id { get; set; }

        public int? Associated_To_Chapter { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public int? Status { get; set; }

        public string Body { get; set; }

        public int? Type { get; set; }

        public int? Category { get; set; }

        public int? Likes { get; set; }

        public int? Dislikes { get; set; }

        [StringLength(144)]
        public string Slug { get; set; }

        public int? FavoriteCount { get; set; }

        public int? ViewCount { get; set; }

        public int? Parent { get; set; }

        public int? Author { get; set; }

        public int? LastEditor { get; set; }

        [StringLength(512)]
        public string Tags { get; set; }

        public bool? Is_Published { get; set; }

        public DateTime? Published_On { get; set; }
    }
}
