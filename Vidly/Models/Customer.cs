﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        // Data Annotations - Name attribute is not nullable
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        // Navigation property
        public MembershipType MembershipType { get; set; }
        // Entity treats this as foreign key
        public byte MembershipTypeId { get; set; }
    }
}