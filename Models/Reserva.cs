using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade da suíte é maior ou igual ao número de hóspedes
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Lançar uma exceção caso a capacidade seja menor que o número de hóspedes
                throw new Exception("Número de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Calcula o valor da diária
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Aplica um desconto de 10% se a reserva for igual ou maior que 10 dias
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10m; // Desconto de 10%
            }

            return valor;
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }

    public class Suite
    {
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(int capacidade, decimal valorDiaria)
        {
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}