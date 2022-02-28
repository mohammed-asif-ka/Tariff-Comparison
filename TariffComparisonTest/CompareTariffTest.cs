using TariffComparisonAPI;
using Xunit;

namespace TariffComparison.Test
{
    public class CompareTariffTest
    {
        [Theory]
        [InlineData(3500,830)]
        [InlineData(4500, 1050)]
        [InlineData(6000, 1380)]
        public void CalculateBasicElecticityTariffTest(double consumption, double expected)
        {
            var tariffObj = TariffCalculations.CalculateBasicElecticityTariff(consumption);
            Assert.Equal(expected, tariffObj.AnnualCosts);
        }

        [Theory]
        [InlineData(3500, 800)]
        [InlineData(4500, 950)]
        [InlineData(6000, 1400)]
        public void CalculatePackagedTariffTest(double consumption, double expected)
        {
            var tariffObj = TariffCalculations.CalculatePackagedTariff(consumption);
            Assert.Equal(expected, tariffObj.AnnualCosts);
        }
    }
}