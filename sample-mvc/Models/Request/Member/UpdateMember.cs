﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sample_mvc.Models.Request.Member
{
    public class UpdateMember
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}