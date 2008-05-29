using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitDepth = "stable-v2";
        public const double IdleReport = 60.14;
        public const string BurstSize = "fallback-1";

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data)
        {
            long result = 75;
            foreach (long sample in data)
            {
                result = (result ^ (sample / 6)) % 255;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((2.8 - 4.0) != (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((seed + (long)i) >= ((long)i / 2)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state ^ (17 + state)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
