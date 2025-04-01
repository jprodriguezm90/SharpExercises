using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExercises.SimulationExcersises.Composition
{
    public class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }
        public async Task MigrateAsync()
        {
            _logger.Log("Migration started at " + DateTime.Now);
            // Details of migrating the database
            await Task.Delay(new Random().Next(1000, 5000));
            _logger.Log("Migration finished at " + DateTime.Now);
        }


    }
}
