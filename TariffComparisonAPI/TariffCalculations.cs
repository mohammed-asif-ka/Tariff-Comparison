using TariffComparisonAPI.Models;
using System.Linq;

namespace TariffComparisonAPI
{
    /// <summary>
    /// Definition of Tariff calculations
    /// </summary>
    public static class TariffCalculations
    {
        /// <summary>
        /// Calculate Tariff
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public static IList<Tariff> CalculateTariff(double consumption) 
        {
            try
            {
                var tariff = new List<Tariff>();
                tariff.Add(CalculateBasicElecticityTariff(consumption));
                tariff.Add(CalculatePackagedTariff(consumption));
                return tariff.OrderBy(x => x.AnnualCosts).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Calculate Basic Electicity Tariff
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public static Tariff CalculateBasicElecticityTariff(double consumption)
        {
            try
            {
                var basicElectricityTariff = new Tariff()
                {
                    AnnualCosts = (5 * 12) + (consumption * 0.22),
                    TariffName = "Basic Electriciy Tariff"
                };
                return basicElectricityTariff;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Calculate Packaged Tariff
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public static Tariff CalculatePackagedTariff(double consumption)
        {
            try
            {
                var packagedTariff = new Tariff()
                {
                    AnnualCosts = consumption > 4000 ? (800 + ((consumption - 4000) * 0.30)) : 800,
                    TariffName = "Packaged Tariff"
                };
                return packagedTariff;
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }


    }
}
