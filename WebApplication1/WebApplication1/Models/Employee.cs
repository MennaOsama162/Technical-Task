﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class Employee
{
    [Key]
    public int id { get; set; }

    [Required]
    [Column("اسم العميل")]
    [StringLength(255)]
    public string اسم_العميل { get; set; }

    public string توصيف { get; set; }

    [StringLength(255)]
    public string الوظيفة { get; set; }

    [Column("ادخال بواسطة")]
    [StringLength(255)]
    public string ادخال_بواسطة { get; set; }

    [Column("تاريخ الادخال")]
    public DateOnly? تاريخ_الادخال { get; set; }

    [Column("اخر تعديل في")]
    public DateOnly? اخر_تعديل_في { get; set; }

    [Column("رجل المبيعات")]
    [StringLength(255)]
    public string رجل_المبيعات { get; set; }

    [Column("مصدر العميل")]
    [StringLength(255)]
    public string مصدر_العميل { get; set; }

    [Column("تصنيف العميل")]
    [StringLength(255)]
    public string تصنيف_العميل { get; set; }
}