using System;

namespace Simple_Workflow_Engine
{
    public class NotifyVideoServiceReadyForEncodingActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("<< TODO >> Call a web service provided by a third-party video encoding service to tell them a video is ready for encoding.");
        }
    }
}