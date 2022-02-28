using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TariffComparisonAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompareTariffController : ControllerBase
    {
        private readonly ILogger<CompareTariffController> _logger;

        /// <summary>
        /// Compare Tariff Controller
        /// </summary>
        /// <param name="logger"></param>
        public CompareTariffController(ILogger<CompareTariffController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Calculate Tariff
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        [HttpGet(Name = "CalculteTariff{Consumption=consumption")]
        public IActionResult CalculateTariff(double consumption)
        {
            try
            {
                var result = TariffCalculations.CalculateTariff(consumption);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
