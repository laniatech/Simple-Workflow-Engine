using System.Collections.Generic;

namespace Simple_Workflow_Engine
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;

        // Constructor, Create a new empty list of activities in the Heap.
        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        // Register and remove activities.
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