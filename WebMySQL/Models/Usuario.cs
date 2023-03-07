using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMySQL.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Idade")]
        [Column("Idade")]
        public string Idade { get; set; }

        [Display(Name = "Civil")]
        [Column("Civil")]
        public string Civil { get; set; }

        [Display(Name = "CPF")]
        [Column("CPF")]
        public string CPF { get; set; }

        [Display(Name = "Estado")]
        [Column("Estado")]
        public string Estado { get; set; }

        [Display(Name = "Cidade")]
        [Column("Cidade")]
        public string Cidade { get; set; }
    }
}
