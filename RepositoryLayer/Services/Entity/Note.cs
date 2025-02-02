﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryLayer.Services.Entity
{
    public class Note
    {
        [Key]
      
        public int noteId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Colour { get; set; }
        public bool IsArchive { get; set; }
        public bool IsPin { get; set; }
        public bool IsReminder { get; set; }

        public bool IsTrash { get; set; }
        public DateTime Reminder { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User user { get; set; }
    }
}
