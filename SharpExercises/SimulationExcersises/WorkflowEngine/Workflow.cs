using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExercises.SimulationExcersises.WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;
        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
        public void RemoveActivity(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
