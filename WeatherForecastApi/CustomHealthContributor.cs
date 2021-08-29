using System.Collections.Generic;
using Steeltoe.Common.HealthChecks;

namespace WeatherForecastApi
{
    public class CustomHealthContributor : IHealthContributor
    {
        public string Id => "CustomHealthContributor";
        
        public HealthCheckResult Health()
        {
            const HealthStatus status = HealthStatus.DOWN;

            return new HealthCheckResult
                   {
                       Status = status,
                       Details = new Dictionary<string, object>
                                 {
                                     { "status", status.ToString() },
                                     {
                                         "error", new
                                                  {
                                                      message = "Some error message",
                                                      stackTrace = "Some stack trace",
                                                  }
                                     },
                                 },
                   };
        }
    }
}
