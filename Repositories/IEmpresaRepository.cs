using System;
using System.Collections.Generic;
using Lamppit_Api.Models;

namespace Lamppit.Api.Repositories{
    public interface IEmpresaRepository
    {
        void Adicionar(Empresa emp);
        void Alterar(Empresa emp);
        IEnumerable<Empresa> ListarEmpresa();
        Empresa ObterPorId(int id);
        void RemoveEmpresa(Empresa emp);
    }
}
