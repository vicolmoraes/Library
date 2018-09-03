//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Main.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Livro
    {
        public Livro()
        {
            this.Item = new HashSet<Item>();
        }

        public int IdLivro { get; set; }
        public int IdEditora { get; set; }
        [Required(ErrorMessage = "O nome do livro � obrigat�rio!", AllowEmptyStrings = false)]
        public string NomeLivro { get; set; }
        [Required(ErrorMessage = "A categoria � obrigat�rio!", AllowEmptyStrings = false)]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "O pre�o � obrigat�rio!", AllowEmptyStrings = false)]
        public double Preco { get; set; }
        [Required(ErrorMessage = "A edi��o � obrigat�rio!", AllowEmptyStrings = false)]
        public string Edicao { get; set; }
        [Required(ErrorMessage = "O nome do autor � obrigat�rio!", AllowEmptyStrings = false)]
        public string Autor { get; set; }
       
        [Display(Name = "Estoque", Description = "O estoque deve estar entre 0 e 50")]
        [Range(0, 50)]
        public int Estoque { get; set; }


        public virtual Editora Editora { get; set; }
        public virtual ICollection<Item> Item { get; set; }
    }
}
