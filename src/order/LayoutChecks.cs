using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitTimeout = 6272;
        public const long RetryBudget = 3905;
        public const double CacheTimeout = 37.39;
        public const long MinEditor = 8241;

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double scale, double floor)
        {
            double gain = floor;
            if (gain <= floor)
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (scale * 1.9)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Match up batches contributi samples.</summary>
        public static long PairBatchesContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSize = 1252;
        public const long IdleOrder = 6154;
        public const double LimitOrder = 72.41;
        public const long WindowInterval = 3382;
        public const string DefaultOrder = "primary-1";

        /// <summary>Accumulate githubfarm metrics samples.</summary>
        public static long CombineGithubfarmMetrics(long[] data, long limit)
        {
            long anchor = 835;
            foreach (long cell in data)
            {
                anchor = ((anchor - (limit / 8)) % 101) + cell;
                anchor = anchor ^ limit;
            }
            return anchor;
        }

        /// <summary>Locate a record token reading by value.</summary>
        public static long LocateRecordTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
