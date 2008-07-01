using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first checks window entry that matches the target.</summary>
        public static long FindChecksWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Synced,
            Done,
            Queued,
        }
    }
}
