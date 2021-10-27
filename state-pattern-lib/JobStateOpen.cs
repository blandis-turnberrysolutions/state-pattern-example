using System;

namespace state_pattern_lib
{

    public class JobStateOpen : IJob
    {
        private readonly Job job;

        public JobStateOpen(Job job)
        {
            this.job = job;
        }

        public JobStates State => JobStates.Open;

        public void Close()
        {
            //TODO: put code that should execute when an open job gets closed here
        }

        public void Open()
        {
            throw new InvalidOperationException("Can't open a job that is already opened");
        }
    }
}
