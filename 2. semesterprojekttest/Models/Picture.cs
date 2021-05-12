﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _2._semesterprojekttest.Models
{
    public partial class Picture
    {
        [Key]
        [Column("PictureID")]
        public int PictureId { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column("TypeID")]
        public int? TypeId { get; set; }
        [StringLength(10)]
        public string FileType { get; set; }
        public byte[] Foto { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(CruizeUser.Pictures))]
        public virtual CruizeUser User { get; set; }
    }
}