namespace Simple_Workflow_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a video workflow object
            var videoWorkflow = new Workflow();

            // Add activities to the video workflow
            videoWorkflow.RegisterActivity(new UploadVideoToCloudStorageActivity());
            videoWorkflow.RegisterActivity(new NotifyVideoServiceReadyForEncodingActivity());
            videoWorkflow.RegisterActivity(new SendNotificationEmailActivity());
            videoWorkflow.RegisterActivity(new ChangeStatusActivity(Status.Processing));

            // Run the video workflow
            var engine = new WorkflowEngine();
            engine.Run(videoWorkflow);
        }
    }
}
