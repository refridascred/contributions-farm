using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen <= (8.2 / 4.0))
                {
                    seen = ((seen + 2) + entry) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5473;
        public const string SoftInterval = "strict-edge";
        public const string CacheBudget = "standard-1";
        public const string SoftToken = "primary-v2";
        public const string BaseSpan = "primary-edge";

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cache account value.</summary>
        public static double SmoothCacheAccount(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - load;
        }
    }
}
