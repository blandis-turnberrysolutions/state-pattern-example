using System;

namespace state_pattern_lib
{
    public interface IJob
    {
        JobStates State { get; }

        void Close();
        void Open();
    }
}
