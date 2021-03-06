﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Domain.Models
{
    [Table("user_point_logs")]
    public class UserPointLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public int Point { get; set; }
        public DateTime CreateTime { get; set; }
        public virtual User User { get; set; }
        public virtual ActionLog ActionLog { get; set; }
    }
}