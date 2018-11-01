using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS1 {
    class Moto {
        string marca;
        string modelo;
        string cor;
        int marcha = 0;
        public string denominacaoMarcha = null;
        public void Imprimir() {
            Console.WriteLine($"Marca: {marca} Modelo: {modelo} Cor: {cor} e está na {MarchaExtenso()} marcha");
        }
        public string MarchaExtenso() {
            if (marcha == 0) {
                denominacaoMarcha = "neutro";
            } else if (marcha == 1) {
                denominacaoMarcha = "primeira";
            } else if (marcha == 2) {
                denominacaoMarcha = "segunda";
            } else if (marcha == 3) {
                denominacaoMarcha = "terceira";
            } else if (marcha == 4) {
                denominacaoMarcha = "quarta";
            } else {
                Console.WriteLine("Não foi definida uma marcha corretamente");
            }
            return denominacaoMarcha;
        }
        public Moto(string marca, string modelo, string cor, int marcha) {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.marcha = marcha;
        }
    }
}
