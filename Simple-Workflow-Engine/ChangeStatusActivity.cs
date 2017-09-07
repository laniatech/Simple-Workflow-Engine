using System;

namespace Simple_Workflow_Engine
{
    public class ChangeStatusActivity : IActivity
    {
        private Status _status;

        public ChangeStatusActivity(Status status)
        {
            this._status = status;
        }

        public void Execute()
        {
            Console.WriteLine("<< TODO >> Change the status of the video recording in the database to \"{0}\"", _status);
        }
    }
}