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

    public partial class Item
    {
        public int IdItem { get; set; }
        public int IdLivro { get; set; }
        public int IdPedido { get; set; }

        [Required(ErrorMessage = "A quantidade � obrigat�rio!", AllowEmptyStrings = false)]
        public int Quantidade { get; set; }
        public virtual Livro Livro { get; set; }
        public virtual Pedido Pedido { get; set; }

       
    }
}
