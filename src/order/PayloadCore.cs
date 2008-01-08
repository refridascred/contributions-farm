using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (bound < (bound ^ bound))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Synced,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
