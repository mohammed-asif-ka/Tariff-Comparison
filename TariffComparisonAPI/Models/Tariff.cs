namespace TariffComparisonAPI.Models
{
    public class Tariff
    {
        /// <summary>
        /// basic electricity tariff / Packaged tariff
        /// </summary>
        public string TariffName { get; set; }

        /// <summary>
        /// Annual consumption cost
        /// </summary>
        public double AnnualCosts { get; set; }
    }
}
