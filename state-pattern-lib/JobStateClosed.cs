using System;

namespace state_pattern_lib
{

    public class JobStateClosed : IJob
    {
        private readonly Job job;

        public JobStateClosed(Job job)
        {
            this.job = job;
        }

        public JobStates State => JobStates.Closed;

        public void Close()
        {
            throw new InvalidOperationException("Can't close a job that is already closed");
        }

        public void Open()
        {
            //TODO: put code that should execute when a closed job gets opened here            
        }
    }
}
