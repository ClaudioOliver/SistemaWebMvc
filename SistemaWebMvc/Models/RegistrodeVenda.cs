using SistemaWebMvc.Models.Enums;
using System;

namespace SistemaWebMvc.Models
{
    public class RegistrodeVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public Status status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistrodeVenda() { }

        public RegistrodeVenda(int id, DateTime data, double valor, Status status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            this.status = status;
            Vendedor = vendedor;
        }
    }
}
