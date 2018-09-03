using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    class Validacao
    {
        public static IEnumerable<ValidationResult> Valida(Object objeto)
        {
            var erros = new List<ValidationResult>();
            var contexto = new ValidationContext(objeto, null, null);
            Validator.TryValidateObject(objeto, contexto, erros, true);
            return erros;
        }
    }
}
