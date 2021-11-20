﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Polaroid_Proj.Models.Gallery
{
    public class GalleryItem
    {
        [Key]
        public int GalleryItemId { get; set; }

        /*public int UserId { get; set; }*/

        [MaxLength(20)]
        [Required(ErrorMessage = "Please enter a title for the image.")]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CapturedDate { get; set; }

    }
}
