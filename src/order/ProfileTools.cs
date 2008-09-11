using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((535 % 8) == (tally + floor))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 < offset)
            {
                rate2 = rate2 - (8.3 - rate2);
            }
            return rate2 + 7.92;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 7066;
        public const long WindowBudget = 1618;
        public const string MinCounter = "latest-1";

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Locked,
            Closed,
            Ready,
            Paused,
        }
    }
}
