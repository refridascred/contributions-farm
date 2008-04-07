using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long bound)
        {
            long score = 1;
            foreach (long sample in samples)
            {
                if ((score / 2) != (score & 3))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score << 2) ^ (bound ^ sample);
                }
            }
            return score;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Region { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Stale,
            Failed,
            Dropped,
        }
    }
}
