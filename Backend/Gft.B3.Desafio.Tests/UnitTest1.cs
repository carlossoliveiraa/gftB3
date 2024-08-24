using Gft.B3.Desafio.Api.Service;

namespace Gft.B3.Desafio.Tests
{
    [TestClass]
    public class CalculoCDBTests
    {
        [TestMethod]
        public void CalcularValorFinal_ComValorInicialPositivoERetornoEsperado()
        {
            // Arrange
            var orcamento = new Orcamento(1000, 6);
            var calculoCDB = new CalculoCDB();

            // Act
            double valorFinal = calculoCDB.CalcularValorFinal(orcamento);

            // Assert
            Assert.AreEqual(1055.77, valorFinal, 1059.76); 
        }

        [TestMethod]
        public void CalcularValorFinal_ComPrazoMuitoLongoERetornoEsperado()
        {
            // Arrange
            var orcamento = new Orcamento(1000, 120); 
            var calculoCDB = new CalculoCDB();

            // Act
            double valorFinal = calculoCDB.CalcularValorFinal(orcamento);

            // Assert
            Assert.IsTrue(valorFinal > 1000); 
        }

        [TestMethod]
        public void CalcularImposto_DeveAplicarTaxaCorretaParaPrazoDe6Meses()
        {
            // Arrange
            var orcamento = new Orcamento(1000, 6);
            var calculoCDB = new CalculoCDB();
            double valorFinal = calculoCDB.CalcularValorFinal(orcamento);
            double lucro = valorFinal - orcamento.ValorInicial;

            // Act
            double imposto = calculoCDB.CalcularImposto(valorFinal, orcamento);

            // Assert
            Assert.AreEqual(lucro * 0.225, imposto, 0.01);
        }

        [TestMethod]
        public void CalcularImposto_DeveAplicarTaxaCorretaParaPrazoSuperiorA24Meses()
        {
            // Arrange
            var orcamento = new Orcamento(1000, 30);
            var calculoCDB = new CalculoCDB();
            double valorFinal = calculoCDB.CalcularValorFinal(orcamento);
            double lucro = valorFinal - orcamento.ValorInicial;

            // Act
            double imposto = calculoCDB.CalcularImposto(valorFinal, orcamento);

            // Assert
            Assert.AreEqual(lucro * 0.15, imposto, 0.01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcularValorFinal_DeveLancarExcecaoParaValorInicialNegativo()
        {
            // Arrange
            var orcamento = new Orcamento(-1000, 12);
            var calculoCDB = new CalculoCDB();

            // Act
            calculoCDB.CalcularValorFinal(orcamento);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcularValorFinal_DeveLancarExcecaoParaPrazoInvalido()
        {
            // Arrange
            var orcamento = new Orcamento(1000, 0); 
            var calculoCDB = new CalculoCDB();
            // Act
            calculoCDB.CalcularValorFinal(orcamento);
        }

    }
}