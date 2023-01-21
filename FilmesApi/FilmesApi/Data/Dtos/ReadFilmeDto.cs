using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Data.Dtos;

public class ReadFilmeDto : Controller
{

    public string? Titulo { get; set; }
    public string? Genero { get; set; }
    public int Duracao { get; set; }
    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
}