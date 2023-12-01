namespace Final_ProjectJob
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Jobs
    {
        [Key]
        public int JobId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int? NoOfPost { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string Qualification { get; set; }

        [StringLength(50)]
        public string Experience { get; set; }

        public string Specialization { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastDateToApply { get; set; }

        [StringLength(50)]
        public string Salary { get; set; }

        [StringLength(50)]
        public string JobType { get; set; }

        [StringLength(200)]
        public string CompanyName { get; set; }

        [StringLength(500)]
        public string CompanyImage { get; set; }

        [StringLength(100)]
        public string Website { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Address { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
