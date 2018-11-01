using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS1 {
    class Program {
        static void Main(string[] args) {
            Aluno jose = new Aluno();
            jose.setNome("Jose Maria");
            jose.setMatricula(123456);
            jose.setCpf("123.456.789-98");
            jose.imprimirNome();
            jose.imprimirMatricula();
            jose.imprimeCPF();

            Aluno maria = new Aluno("Maria José", 654321);
            //Aluno maria = new Aluno("Maria José", "987.654.321-21");
            maria.setCpf("987.654.321-21");
            maria.imprimirNome();
            maria.imprimirMatricula();
            maria.imprimeCPF();
            
            Console.ReadKey();
        }
    }
}
