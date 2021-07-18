using System;
using System.Collections.Generic;
using Lamppit.Api.Repositories;
using Lamppit_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lamppit_Api.Controllers
{
    public class EmpresaController: Controller
    {
        private readonly IEmpresaRepository _repositorio;
        public EmpresaController(IEmpresaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("/empresas")]
        public IActionResult ListarEmpresas()
        {
            return Ok(
                _repositorio.ListarEmpresa()
            );
        }

        [HttpPost("/empresa")]
        public IActionResult AdicionarEmpresa([FromBody]Empresa emp)
        {
            _repositorio.Adicionar(emp);
            return Ok();
        }
        
        [HttpPut("/empresa/{id}")]
        public IActionResult AlterarEmpresa(int id, [FromBody]Empresa emp)
        {
            var empAntigo = _repositorio.ObterPorId(id);
            if(empAntigo == null){
                return NotFound();
            }
            empAntigo.nomeEmpresa = emp.nomeEmpresa;
            empAntigo.cnpj = emp.cnpj;
            empAntigo.endereco = emp.endereco;
            empAntigo.email = emp.email;
            _repositorio.Alterar(empAntigo);
            return Ok();
        }

        [HttpDelete("/empresa/{id}")]
        public IActionResult RemoverEmpresa(int id)
        {
            var emp = _repositorio.ObterPorId(id);
            if(emp == null){
                return NotFound();
            }         
            _repositorio.RemoveEmpresa(emp);
            return Ok();
        }

        [HttpGet("/empresa/{id}")]
        public IActionResult ObterEmpresa(int id)
        {
            var empAntigo = _repositorio.ObterPorId(id);
            if(empAntigo == null){
                return NotFound();
            }         
            return Ok(empAntigo);
        }
    }
}