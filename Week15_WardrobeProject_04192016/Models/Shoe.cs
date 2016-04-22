using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week15_WardrobeProject_04192016.Models
{
    public class Shoe
    {
        /*This is a key property that will automatically add a unique integer for each record*/
        [Key]
        public int ShoeID { get; set; }

        /*The Nickname is required and limited to 30 characters*/
        [StringLength(30, ErrorMessage = "The nickname must not exceed 30 characters.")]
        [Required]
        public string Nickname { get; set; }

        /*The Photo is not required or limited in characters*/
        public string Photo { get; set; }

        /*The Type is required and limited to 15 characters*/
        /*Later- attempt to limit to list related to the class*/
        [StringLength(15, ErrorMessage = "The type must not exceed 15 characters.")]
        [Required]
        public string Type { get; set; }

        /*The Color is required and limited to 15 characters*/
        /*Later- attempt to limit to list of colors*/
        [StringLength(15, ErrorMessage = "The color must not exceed 15 characters.")]
        [Required]
        public string Color { get; set; }

        /*The Season is required*/
        [Required]
        public string Season { get; set; }

        /*The Occ property has a display name and is required*/
        [Display(Name = "Occasion")]
        [Required]
        public string Occ { get; set; }

    }
}