using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistrodeVenda> Venda { get; set; } = new List<RegistrodeVenda>();

        public Vendedor() { }

        public Vendedor(int id, string name, string email, DateTime data, double salarioBase, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            Data = data;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVenda(RegistrodeVenda rv)
        {
            Venda.Add(rv);
        }

        public void RemoveVenda(RegistrodeVenda rv)
        {
            Venda.Remove(rv);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Venda.Where(rv => rv.Data >= inicial && rv.Data <= final).Sum(rv => rv.Valor);

        }
    }
}
