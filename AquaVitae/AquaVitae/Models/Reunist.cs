using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AquaVitae.Models
{
    [Table("Reunisten")]
    public class Reunist
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Feutmans, zo noemen zijn vrienden hem!")]
        public string Voornaam { get; set; }
        
        [Required(ErrorMessage = "Feutmans, zo spreek je meneer aan!")]
        public string Achternaam { get; set; }
        
        [Required(ErrorMessage = "Feutmans, hoe oud is meneer?")]
        [Display(Name= "Geboorte datum")]
        [DataType(DataType.Date)]
        public DateTime GeboorteDatum { get; set; }
        
        [Range(1957, int.MaxValue, ErrorMessage = "Feutmans, je kan niet eerder dan het oprichtingsjaar invullen")]
        public int Corpsjaar { get; set; }

        [Required(ErrorMessage = "Feutmans, je moet ze kunnen bellen als je knaken op zijn!")]
        [DataType(DataType.PhoneNumber)]
        public string Telefoonnummer { get; set; }

        [Required(ErrorMessage = "Feutmans, netjes een @ en een .XX er in zetten")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Feutmans, dit mag echt alles zijn!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Feutmans, bedenk een wachtwoord, je kan het wel")]
        [StringLength(255, ErrorMessage = "Minimaal 5 tekens", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Feutmans, bevestig je wachtwoord")]
        [StringLength(255, ErrorMessage = "Minimaal 5 tekenss", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}