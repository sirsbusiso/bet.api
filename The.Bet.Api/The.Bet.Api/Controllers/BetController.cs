using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using The.Bet.Api.Services.Interfaces;

namespace The.Bet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {

        private readonly IBetService _betService;
        public BetController(IBetService betService)
        {
            _betService = betService;
        }
        [HttpGet]
        public IActionResult GetAllBets()
        {
            var res = _betService.GetBets();

            return Ok(res);
        }

        [HttpPost]
        [Route("PlaceBet")]
        public IActionResult PlaceBet(int bet)
        {
            var res = _betService.PlaceBet(bet);
            return Ok(res);
        }

        [HttpPost]
        [Route("Spin")]
        public IActionResult Spin()
        {
            var res = _betService.Spin();
            return Ok(res);
        }
    }
}
