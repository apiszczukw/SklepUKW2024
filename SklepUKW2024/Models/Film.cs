﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SklepUKW2024.Models
{
    public class Film
    {
        // klucz główny 
        // inne opcje: Id lub anotacja [Key]
        public int FilmId { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł")]
        public string Title { get; set; }

        public string Director { get; set; }

        [StringLength(200)]
        public string Desc { get; set; }

        // Klucz obcy
        // Inne opcje: CategoryCategoryId
        // [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
