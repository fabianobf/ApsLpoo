using System;
namespace APS
{
    public class Aluno
    {
        public Aluno()
        {
            string nomeCompleto;
            long matricula;
            string CPF;

            public void imprimirNome()
            {
                Console.WriteLine($"Nome: {nomeCompleto}");
            }
            public void imprimirMatricula()
            {
                Console.WriteLine($"Matricula: {matricula}");
            }
            public void imprimeCPF()
            {
                Console.WriteLine($"CPF: {CPF}");
            }
        }
    }
}