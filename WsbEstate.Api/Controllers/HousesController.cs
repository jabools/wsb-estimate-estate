using System;
using Microsoft.AspNetCore.Mvc;
using WsbEstate.Api.Services;
using WsbEstate2.Model;

namespace WsbEstate.Api.Controllers
{
    [ApiController]
    [Route("houses")]
    public class HousesController : ControllerBase
    {
        private readonly PredictionService _predictionService;

        public HousesController(PredictionService predictionService)
        {
            _predictionService = predictionService;
        }
        
        [HttpPost("predict")]
        public IActionResult Predict(ModelInput data)
        {
            var predictionResult = _predictionService.Predict(data);

            return Ok(predictionResult);
        }
    }
}