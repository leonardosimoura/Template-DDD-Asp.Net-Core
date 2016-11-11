using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace AppTemplate.Domain.Entities
{
    [DebuggerDisplay("IdUsuario = {IdUsuario}; Nome = {Nome}; Email = {Email}")]
    [Table("Usuario")]
    public class Usuario 
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(200)]
        public string Nome { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(200)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(200)]
        public string Senha { get; set; }
        public DateTime? DataRegistro { get; set; }

        public void Registrar()
        {
            if (DataRegistro.HasValue == false)
            {
                DataRegistro = DateTime.Now;
            }
        }

    }
}
