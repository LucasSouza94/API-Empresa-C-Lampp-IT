using System;

namespace Lamppit_Api.Models
{
    public class Empresa
    {
        public Empresa()
        {
            // Guid GERA UM ID DE FORMA NÃO SEQUENCIAL
            //Id = Guid.NewGuid();
            id = 0;
        }
        public int id { get; set;}
        public string nomeEmpresa { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }
    }
}