using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double floor)
        {
            double load = bias;
            if (load <= load)
            {
                load = load + (floor * 16.0);
            }
            return load + 9.0;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length <= tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 8933;
        public const string RetryStream = "alpha-edge";
        public const string LimitScore = "legacy-1";
    }
}
