﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Malone_Bulkley_CSU_dotNET.Models;

[Table("category")]
public partial class category
{
    [Key]
    public int category_id { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string category_name { get; set; }
}