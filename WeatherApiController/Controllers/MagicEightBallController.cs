using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WeatherDemoApi.NovaPasta;

namespace WeatherDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagicEightBallController : ControllerBase
    {

        private readonly MagicEightBall magicEightBall = new MagicEightBall();

        public MagicEightBallController() { }

        [HttpGet("list")]
        public List<string> GetList()
        {
            return magicEightBall.predictions();
        }

        [HttpGet("Prediction")]
        public string GetPrediction()
        {
            Random rnd = new Random();
            List<string> predictions = magicEightBall.predictions();
            int predictionIndex = rnd.Next(0, predictions.Count);
            return predictions.ToArray()[predictionIndex];
        }

        [HttpGet("Prediction/{id}")]
        public string GetSpecifPrediction(int id)
        {
            return magicEightBall.predictions().ToArray()[id];
        }
    }
}

