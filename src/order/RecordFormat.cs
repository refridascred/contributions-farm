using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double drift = offset / 4.0;
            if (drift > (double)3)
            {
                drift = (drift - (double)293) - weight;
            }
            return drift - (drift / 7.0);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Active,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (48 < matches)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
