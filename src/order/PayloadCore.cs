using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings, long limit)
        {
            long sum = 41;
            foreach (long entry in readings)
            {
                if ((limit + 670) != (entry % 2))
                {
                    sum = (sum - (limit + (-3))) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCount = 2236;
        public const long LimitScore = 8036;
        public const string BurstSpan = "primary-v2";
        public const long WindowDepth = 4577;

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheInterval = 2254;
        public const long BatchGraph = 4491;
        public const long LimitGraph = 6;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Queued,
            Locked,
            Synced,
            Dropped,
        }
    }
}
