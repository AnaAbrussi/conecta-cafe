using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Avaliação")]
public class Avaliacao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe a pessoa")]
    [StringLength(60, ErrorMessage = "A pessoa deve possuir no máximo 60 caracteres")]
    public string pessoa { get; set; }   

    [Required(ErrorMessage = "Por favor, informe o título")]
    [StringLength(100, ErrorMessage = "O título deve possuir no máximo 100 caracteres")]
    public string Titulo { get; set; }   

    [Required(ErrorMessage = "Por favor, informe o texto")]
    [StringLength(500, ErrorMessage = "O texto deve possuir no máximo 500 caracteres")]
    public string Texto { get; set; }   

    [Column(TypeName = "Decimal(1,0)")]
    [Required(ErrorMessage = "Por favor, informe a nota")]
    public decimal Nota { get; set; } 

    [Display(Name = "Data da Avalição")]
    [DataType(DataType.Date)]
    public DateTime DataAvaliacao { get; set; }
}