namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuizesQuestionsLk")]
    public partial class QuizesQuestionsLk
    {
        public int? Course_Id { get; set; }

        public int? Chapter_Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Question_Id { get; set; }
    }
}
