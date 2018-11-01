using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS1 {
    class Aluno {
        string NomeCompleto;
        long Matricula;
        string Cpf;
        public Aluno (string nome, long matricula) {
            NomeCompleto = nome;
            Matricula = matricula;
        }
        public Aluno (string nome, string cpf) {
            NomeCompleto = nome;
            Cpf = cpf;
        }
        public Aluno() { }
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
