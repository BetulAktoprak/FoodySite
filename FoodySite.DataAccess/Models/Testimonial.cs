﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodySite.DataAccess.Models
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }
        public string NameSurname { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Title { get; set; }
    }
}
