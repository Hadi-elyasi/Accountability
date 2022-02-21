using Core.Services;
using Microsoft.AspNetCore.Mvc;
using OrganisationChart.Services;

namespace OrganisationChart.Controllers
{
    public class OChartController : Controller
    {
        private readonly IOChartServices _chartService;

        public OChartController(IOChartServices chartService)
        {
            _chartService = chartService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
