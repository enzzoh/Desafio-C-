using advocaciaPrincipal.Models;
using System;
using Xunit;

namespace Teste1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Advogado ad = new Advogado();
            ad.idade = 20;
            bool esperado = true;
            bool resultado = false;





            resultado = ad.verificarseadvogadomaiordeidade();


            Assert.Equal(esperado, resultado);

        }
    }
}
