using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Models;
using MinhaPrimeiraAPI.Repositorios;
using MinhaPrimeiraAPI.Repositorios.Interfaces;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;
        public TarefaController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<TarefaModel>>> BuscarTodosUsuarios()
        {
            List<TarefaModel> tarefas = await _tarefaRepositorio.BuscarTodasTarefas();
            return Ok(tarefas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<TarefaModel>>> BuscarPorId(int id)
        {
            TarefaModel tarefa = await _tarefaRepositorio.BuscarPorID(id);
            return Ok(tarefa);
        }

        [HttpPost]
        public async Task<ActionResult<TarefaModel>> Cadastrar([FromBody] TarefaModel tarefaModel)
        {
            TarefaModel tarefa = await _tarefaRepositorio.Adicionar(tarefaModel);

            return Ok(tarefa);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TarefaModel>> Atualizar([FromBody] TarefaModel tarefaModel, int id)
        {
            tarefaModel.Id = id;
            TarefaModel usuario = await _tarefaRepositorio.Atualizar(tarefaModel, id);
            return Ok(usuario);
        }
            
        [HttpDelete("{id}")]
        public async Task<ActionResult<TarefaModel>> Apagar(int id)
        {
            bool apagado = await _tarefaRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
