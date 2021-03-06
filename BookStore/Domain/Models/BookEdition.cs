﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Domain.Models
{
    [Table("book_editions")]
    public class BookEdition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Filename { get; set; }

        [StringLength(1000)]
        public string OriginalFilename { get; set; }

        public long Filesize { get; set; }
        public int PushCount { get; set; }
        public int DownloadCount { get; set; }
        public int FavoriteCount { get; set; }

        [StringLength(2000)]
        public string CheckSum { get; set; }

        public DateTime CreateTime { get; set; }


        public virtual Book Book { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<BookEditionComment> BookEditionComments { get; set; }
    }
}