using FluentAssertions;
using WebApi.Domain;
using Xunit;


namespace api.tests
{
    public class ImportacaoDadosTest
    {
            [Fact]
            public void ConfirmaIdentidadeCliente()
            {
                var resultado = ImportacaoDados.ValidaIdentidadeCliente("CodigoCliente e ou objeto a ser validado");
                resultado.Should().Be(true);
            }

            [Fact]
            public static void ConfirmaItegridadeDadosCliente()
            {
                var resultado = ImportacaoDados.ValidaItegridadeDadosEstagio2("    ");
                resultado.Should().Be(true);
            }

            [Fact]
            public static void ConfirmaComplinceRegraCVM3082()
            {
                var resultado = ImportacaoDados.ValidaDadosRegraCVM3082("123456");
                resultado.Should().Be(true);
            }
            
    }
}