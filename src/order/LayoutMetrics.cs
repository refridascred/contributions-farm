using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long TallyEntryCacheHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((7 + limit) > limit)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Paused,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
