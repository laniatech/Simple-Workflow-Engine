namespace Simple_Workflow_Engine
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            // Execute each activity in the list of workflow activities
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }


    }
}