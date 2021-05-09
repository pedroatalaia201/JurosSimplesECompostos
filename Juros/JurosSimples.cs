using System;

namespace Juros {
    class JurosSimples {
        public double Capital { get; set; }
        public double Taxa { get; set; }
        public int Tempo { get; set; }
        public double Montante { get; private set; }

        public JurosSimples() {
        }

        public JurosSimples(double capital, double taxa, int tempo) {
            Capital = capital;
            Taxa = taxa;
            Tempo = tempo;
        }

        public double Calcular() {
            double juros = 0;

            juros = Capital * (Taxa / 100) * Tempo;
            Montante = Capital + juros;

            return Montante;
        }
    }
}
