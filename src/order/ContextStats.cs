using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data)
        {
            long state = 976;
            foreach (long entry in data)
            {
                if (!((entry / 5) >= ((long)data.Length >> 4)))
                {
                    state = state + (state ^ state);
                    state = (state ^ (entry << 2)) % 101;
                }
                state = (state ^ (long)data.Length) % 101;
            }
            if (state < 22)
            {
                state = (state - (state << 3)) % 101;
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (14.0 * 8.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
