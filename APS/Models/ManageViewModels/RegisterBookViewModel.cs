﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APS.Models.ManageViewModels
{
    public class RegisterBookViewModel
    {
        public Guid BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string PublishingCompany { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public decimal Value { get; set; }
        [Required]
        public int InitialStock { get; set; }
        [Required]
        public int InStock { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public bool BookStatus { get; set; } = true;

        public string SellerId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
