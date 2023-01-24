using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titre { get; set; }
        public string Chapeau { get; set; }
        public string Contenu { get; set; }
        public string Icon { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string Auteur { get; set; }
        [Display(Name = "Date Publication")]
        public DateTime DateCreation { get; set; }
        [Display(Name = "Date Modification")]
        public DateTime DateModification { get; set; }
        public string Etat { get; set; }
        public List<Categorie_Article> Categories_Articles { get; set; }
        [Display(Name = "Langue")]
        public int LangueId { get; set; }
        public Langue Langue { get; set; }


    }
}
