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

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + value) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
