using System.ComponentModel.DataAnnotations;

namespace ExerciceFormulaire.Classes
{
    public class Contact
    {
        [Required(ErrorMessage = "Le nom est requis.")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "L'email est requis.")]
        [RegularExpression(@"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\-_]+)(\.)?([a-zA-Z0-9\-_]+)?(\.){1}([a-zA-Z]{2,11})$", ErrorMessage = "Adresse Mail invalide")]

        public String Email { get; set; }

        [Required(ErrorMessage = "L'adresse est requise.")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Le code postal est requis.")]
        public string CodePostal { get; set; }

        [Required(ErrorMessage = "L'âge est requis.")]
        [Range(18, int.MaxValue, ErrorMessage = "Il faut avoir minimum 18 ans.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "La date de naissance est requise.")]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }

        public bool EstMarie { get; set; }

        public CouleurFavorite CouleurFavorite { get; set; }
    }

    public enum CouleurFavorite
    {
        Rouge,
        Bleu,
        Vert,
        Jaune,
        Autre
    }
}