namespace SharpExercises.SimulationExcersises.WorkflowEngine
{
    public interface IWorkflow
    {
        void RegisterActivity(IActivity activity);
        void RemoveActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();

    }
}
