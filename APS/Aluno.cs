using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS {
    class Aluno {
        string NomeCompleto;
        long Matricula;
        string Cpf;

        public void setNome(string nome) {
            NomeCompleto = nome;
        }
        public void setMatricula(long matricula) {
            Matricula = matricula;
        }
        public void setCpf(string cpf) {
            Cpf = cpf;
        }
        public void imprimirNome() {
            Console.WriteLine($"Nome: {NomeCompleto}");
        }
        public void imprimirMatricula() {
            Console.WriteLine($"Matricula: {Matricula}");
        }
        public void imprimeCPF() {
            Console.WriteLine($"CPF: {Cpf}");
        }
    }
}
