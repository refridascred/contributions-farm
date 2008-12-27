using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] values, long seed)
        {
            long total = 120;
            foreach (long entry in values)
            {
                if ((entry - entry) <= entry)
                {
                    total = ((total + (68 * 5)) % 97) - seed;
                }
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long acc = 5;
            foreach (long datum in levels)
            {
                if ((double)(long)levels.Length < (7.67 / 2.0))
                {
                    acc = (acc ^ (datum << 3)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Idle,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (target < count)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
