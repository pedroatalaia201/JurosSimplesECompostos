using System;

namespace Juros {
    class JurosCompostos {
        public double Capital { get; set; }
        public double Taxa { get; set; }
        public int Tempo { get; set; }
        public double Montante { get; private set; }

        public JurosCompostos() { 
        }

        public JurosCompostos(double capital, double taxa, int tempo) {
            Capital = capital;
            Taxa = taxa;
            Tempo = tempo;
        }

        public double Calcular() {
            double taxaGet = 1;
            double aux = (1.0 + (Taxa/100));

            for(int i = 0; i < Tempo; i++) {
                taxaGet = taxaGet * aux;
            }

            Montante = Capital * taxaGet;

            return Montante;
        }
    }
}
