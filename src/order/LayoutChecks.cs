using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Dropped,
            Stale,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((8.81 + 6.0) < (double)offset))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double weight, double offset)
        {
            double drift = weight;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (double)7) + (double)(long)i) - offset;
            }
            return drift + (weight / 6.0);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen >= (value << 1))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
