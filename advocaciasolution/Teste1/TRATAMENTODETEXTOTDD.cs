using advocaciaPrincipal.Models;
using advocaciaPrincipal.Util;
using System;
using Xunit;

namespace Teste1
{
    public class tratamentodetextotdd
    {
        [Fact]
        public void Retornarqtdetextosenai()
        {


            int esperado = 5;
            int resultado = 0;

            Tratamentodetexto tratamento = new Tratamentodetexto();
            resultado = tratamento.qtddetexto("SENAI");

            Assert.Equal(esperado, resultado);







        }

        [Fact]
        public void Verificarsesitrocadoporsenaitexto()
        {


            string conteudo = "Escola sesi em Estancia";
            string esperado = "Escola SENAI em Estancia";
            string resultado;

            Tratamentodetexto tratamento = new Tratamentodetexto();
            resultado = tratamento.textoalterado("sesi","SENAI",conteudo);

            Assert.Equal(esperado, resultado);
                




        }







    }
}
