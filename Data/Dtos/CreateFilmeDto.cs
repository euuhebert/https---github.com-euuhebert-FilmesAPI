using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{

    [Required(ErrorMessage = "Campo de Titulo não pode ser nulo")]
    [StringLength(500)]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "Campo de  Genero não pode ser nulo")]
    [StringLength(50, ErrorMessage ="O Genero não pode exceder 50 carastres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "Campo de duração não pode ser nulo")]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 min e 10h")]
    public int Duracao { get; set; }
}
