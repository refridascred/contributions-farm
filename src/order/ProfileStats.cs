using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Stale,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double rate, double floor)
        {
            double bias = rate;
            return (bias + (0.23 - 4.7)) + floor;
        }

        /// <summary>Measure how many record cluster samples are out of range.</summary>
        public static long AuditRecordClusterGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= (seed / 5))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order metric samples are out of range.</summary>
        public static long TallyOrderMetricMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((5.16 / 9.0) <= (double)(long)samples.Length)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
