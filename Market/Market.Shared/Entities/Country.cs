using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Shared.Entities
{
    public class Country

    {

        public int Id { get; set; } //(primary key, identity (1,1))

        [Display(Name = "País")] //son etiquetas
        [MaxLength (100, ErrorMessage = "El campo {0} debe contener {1} caracteres")] //Longitud de los caracteres del campo
        [Required (ErrorMessage = "El campo {0} es obligatorio")]

        public string? Name { get; set; } //el ? indica que hace un salto de nulos

        





    }
}
