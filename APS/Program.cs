using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS {
    class Program {
        static void Main(string[] args) {
            Aluno jose = new Aluno();
            jose.setNome("Jose Maria");
            jose.setMatricula(123456);
            jose.setCpf("123.456.789-98");
            jose.imprimirNome();
            jose.imprimirMatricula();
            jose.imprimeCPF();
            Console.ReadKey();
        }
    }
}
