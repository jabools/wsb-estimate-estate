using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.ML;
using WsbEstate2.Model;

namespace WsbEstate.Api.Services
{
    public class PredictionService
    {
        private readonly ILogger<PredictionService> _logger;
        private readonly PredictionEngine<ModelInput, ModelOutput> _engine;

        public PredictionService(ILogger<PredictionService> logger)
        {
            _logger = logger;
            _engine = ConsumeModel.CreatePredictionEngine();
        }

        public ModelOutput Predict(ModelInput data)
        {
            return _engine.Predict(data);
        }
    }
}