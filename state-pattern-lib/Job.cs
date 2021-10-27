using System;

namespace state_pattern_lib
{
    public class Job : IJob
    {
        public Job(JobStates state)
        {
            CurrentState = state switch
            {
                JobStates.Open => new JobStateOpen(this),
                JobStates.Closed => new JobStateClosed(this),
                _ => throw new ArgumentException($"{state} is not a valid Job State"),
            };
        }

        private IJob CurrentState { get; set; }

        public JobStates State => CurrentState.State;

        public void Open()
        {
            CurrentState.Open();
            CurrentState = new JobStateOpen(this);
        }

        public void Close()
        {
            CurrentState.Close();
            CurrentState = new JobStateClosed(this);
        }
    }
}
