using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExercises.SimulationExcersises.Composition
{
    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public async Task InstallAsync()
        {
            _logger.Log("Install started at " + DateTime.Now);
            // Details of the Install process
            await Task.Delay(new Random().Next(1000, 5000));
            _logger.Log("Install finished at " + DateTime.Now);
        }
    }
}
