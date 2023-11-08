using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CA_ReverseEnginnering.Models;

[Index("GradeId", Name = "IX_Students_GradeId")]
public partial class Student
{
    [Key]
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    [Column("height")]
    public float? Height { get; set; }

    [Column("weight")]
    public float? Weight { get; set; }

    public int? GradeId { get; set; }

    public string? Photo { get; set; }

    [ForeignKey("GradeId")]
    [InverseProperty("Students")]
    public virtual Grade? Grade { get; set; }
}
