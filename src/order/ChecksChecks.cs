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

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
