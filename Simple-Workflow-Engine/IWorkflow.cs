using System.Collections.Generic;

namespace Simple_Workflow_Engine
{
    public interface IWorkflow
    {
        void RegisterActivity(IActivity activity);
        void RemoveActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}