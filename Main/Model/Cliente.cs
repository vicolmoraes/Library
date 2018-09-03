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

    public partial class Cliente
    {
        public Cliente()
        {
            this.Pedido = new HashSet<Pedido>();
        }

        public int IdCliente { get; set; }
        [Required(ErrorMessage = "O nome do cliente � obrigat�rio!", AllowEmptyStrings = false)]
        public string NomeCliente { get; set; }
        [Required(ErrorMessage = "O telefone do cliente � obrigat�rio!", AllowEmptyStrings = false)]
        public string TelefoneCliente { get; set; }
        [Required(ErrorMessage = "O CPF � obrigat�rio!", AllowEmptyStrings = false)]
        public string CPF { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}