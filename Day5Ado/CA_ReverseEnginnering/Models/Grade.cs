using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CA_ReverseEnginnering.Models;

public partial class Grade
{
    [Key]
    public int Id { get; set; }

    public string? GradeName { get; set; }

    public string? Section { get; set; }

    [InverseProperty("Grade")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
