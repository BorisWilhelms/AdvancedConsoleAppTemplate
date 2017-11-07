using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public class Program
    {
        private readonly ILogger _logger;

        public Program(ILogger<Program> logger)
        {
            _logger = logger;
        }

        public async Task Run()
        {
            _logger.LogInformation("Hello World");
        }
    }
}
