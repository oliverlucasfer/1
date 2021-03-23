using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno() {
                Id = 1,
                Nome = "Marcos",
                Telefone = "123454645"
            },
            new Aluno() {
                Id = 2,
                Nome = "Mario",
                Telefone = "123454645"
            },
            new Aluno() {
                Id = 3,
                Nome = "Maria",
                Telefone = "123454645"
            },
        };
        public AlunoController() {}

        [HttpGet]

        public IActionResult Get() {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id) {

            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome) {

            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
            if (aluno == null) return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno) {

            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno) {

            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno) {

            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {

            return Ok();
        }
    }
}