// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _2._semesterprojekttest.Models
{
    [Table("CruizeUser")]
    public partial class CruizeUser
    {

        private int _zipCode;

        public CruizeUser()
        {
            Passengers = new HashSet<Passenger>();
            Pictures = new HashSet<Picture>();
            ReportReportedNavigations = new HashSet<Report>();
            ReportReporterNavigations = new HashSet<Report>();
            Requests = new HashSet<Request>();
        }

        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(200)]
        public string Password { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        public int Zipcode
        {
            get { return _zipCode;}
            set
            {
                if (value < 1000 || value > 9999)
                {
                    throw new ArgumentException("ZipCode needs to be between 1000 and 9999");
                }
                _zipCode = value;
            }
        }
        [InverseProperty("User")]
        public virtual Driver Driver { get; set; }
        [InverseProperty(nameof(Passenger.User))]
        public virtual ICollection<Passenger> Passengers { get; set; }
        [InverseProperty(nameof(Picture.User))]
        public virtual ICollection<Picture> Pictures { get; set; }
        [InverseProperty(nameof(Report.ReportedNavigation))]
        public virtual ICollection<Report> ReportReportedNavigations { get; set; }
        [InverseProperty(nameof(Report.ReporterNavigation))]
        public virtual ICollection<Report> ReportReporterNavigations { get; set; }
        [InverseProperty(nameof(Request.User))]
        public virtual ICollection<Request> Requests { get; set; }
    }
}