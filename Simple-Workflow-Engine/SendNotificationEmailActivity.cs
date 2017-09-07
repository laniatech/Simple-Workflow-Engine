using System;

namespace Simple_Workflow_Engine
{
    public class SendNotificationEmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("<< TODO >> Send an email to the owner of the video notifying them that the video started processing.");
        }
    }
}