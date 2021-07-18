using System;
using System.Collections.Generic;
using System.Linq;
using Lamppit_Api.Models;

namespace Lamppit.Api.Repositories{
    public class EmpresaRepository: IEmpresaRepository
    {
        private int cont = 1;
        private readonly List<Empresa> _empre;

        public EmpresaRepository()
        {
            _empre = new List<Empresa>();
        }

        public void Adicionar(Empresa emp)
        {
            emp.id = this.cont++;
            _empre.Add(emp);
        }
        public void Alterar(Empresa emp)
        {
            var index = _empre.FindIndex(0, x => x.id == emp.id);
            _empre[index] = emp;
        }
        public IEnumerable<Empresa> ListarEmpresa()
        {
            return _empre;
        }
        public Empresa ObterPorId(int id)
        {
            return _empre.FirstOrDefault(x => x.id == id);
        }
        public void RemoveEmpresa(Empresa emp)
        {
            _empre.Remove(emp);
        }
    }
}