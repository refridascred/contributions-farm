using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many schema buffer samples are out of range.</summary>
        public static long TallySchemaBufferMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen & 15) < (seen - seen))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
