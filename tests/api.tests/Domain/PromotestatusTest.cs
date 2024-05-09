using FluentAssertions;
using WebApi.Domain;
using Xunit;

namespace web_app_sample_tests
{
    public class PromotestatusTest
    {

        [Fact]
        public static void ClassificaTargeScore()
        {
            var resultado = PromoteStatus.GetTargetstatus(90,7);
            resultado.Should().BeGreaterThanOrEqualTo(10);
        }
    }
}