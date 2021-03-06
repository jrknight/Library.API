﻿using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("tblItemRecord")]
    public class ItemRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ItemId { get; set; }

        public Item Item { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        public DateTime RecordDate { get; set; }

    }
}
