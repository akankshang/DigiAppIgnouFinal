namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Entity_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string User_Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; }

        public int? Role { get; set; }

        [StringLength(550)]
        public string Password { get; set; }

        [StringLength(250)]
        public string Salt { get; set; }

        public DateTime? Last_Login { get; set; }

        public DateTime? Failed_Login { get; set; }

        public int? Failed_Attempt { get; set; }

        public bool? Is_Locked { get; set; }

        public DateTime? Locked_On { get; set; }

        public bool? Is_Active { get; set; }

        public DateTime? DTS { get; set; }
    }
}
