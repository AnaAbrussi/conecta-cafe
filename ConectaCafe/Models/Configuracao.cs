using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Configuração")]
public class Configuracao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(200, ErrorMessage = "A configuração deve possouir no máximo 200 caracteres")]
    public string Horario { get; set; }  

    [StringLength(20, ErrorMessage = "O telefone deve possouir no máximo 20 caracteres")]
    public string Telefone { get; set; }
}