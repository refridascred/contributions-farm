using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((10 - 74) > (329 - seen)) || (item >= (item - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Failed,
            Synced,
            Queued,
        }
    }
}
