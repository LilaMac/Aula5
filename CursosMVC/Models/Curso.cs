using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;

namespace CursosMVC.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        [Column(name: "CodigoDoCurso")]
        public int CursoId { get; set; }
        public string? Descricao { get; set; }
        public decimal CargaHoraria { get; set; }

    }
}