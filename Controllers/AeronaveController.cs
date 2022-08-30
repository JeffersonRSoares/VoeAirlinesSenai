using Microsoft.AspNetCore.Mvc;
using VoeAirlinesSenai.Services;
using VoeAirlinesSenai.ViewModel;

// A controller é uma classe que permite trabalhar com HTTP

// Uma Classe
// Herança no C# - ":"
// URL - Endereço - Caminho
// Rota é um trecho - sub caminho

// Anotations ou anotaçoes []
[Route("api/aeronaves")]
// Controle pode trabalhar com AspNet MVC ou API ou Outros Recursos Web
// Neste caso usaremos ApiController
[ApiController]

public class AeronaveController : ControllerBase
{

    private readonly AeronaveService _aeronaveService;

    public AeronaveController(AeronaveService aeronaveService)
    {
        _aeronaveService = aeronaveService;
    }
    [HttpPost]
    public IActionResult AdicionarAeronave(AdicionarAeronaveViewModel dados)
    {

        var aeronave = _aeronaveService.AdicionarAeronave(dados);
        return Ok(aeronave);

    }
    [HttpGet]
    public IActionResult ListarAeronaves()
    {
        return Ok(_aeronaveService.ListarAeronaves());
    }
    [HttpGet("{id}")]
    public IActionResult ListarAeronavePeloId(int id)
    {
        var aeronave = _aeronaveService.ListarAeronavePeloId(id);
        if (aeronave != null)
        {
            return Ok(aeronave);
        }
        return NotFound();
    }
    [HttpPut("{id}")]
    public IActionResult AtualizarAeronave(int id, AtualizarAeronaveViewModel dados)
    {
        if (id != dados.Id)
        {
            return BadRequest("O id informado na URL é diferente do id informado no corpo da requisição");
        }
        var aeronave = _aeronaveService.AtualizarAeronave(dados);
        return Ok(aeronave);
    }

    [HttpDelete("{id}")]
    public IActionResult ExcluirAeronave(int id)
    {
        _aeronaveService.ExcluirAeronave(id);
        return NoContent();
    }
}
