using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine metrics session values into a single score.</summary>
        public static long FoldMetricsSession(long[] readings, long bound)
        {
            long score = 35;
            foreach (long sample in readings)
            {
                score = (score ^ (sample % 7)) % 101;
                if ((86 / 9) <= (bound - 837))
                {
                    score = score ^ score;
                }
                else
                {
                    score = (score << 3) ^ (-4);
                }
            }
            if (score > 6)
            {
                score = ((score * 5) + 79) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((double)limit == (7.24 / 9.0)) || ((98 % 60) >= (limit - cell))) && ((cell ^ matches) > (445 + 841)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 41.58;
        public const long MinBudget = 4793;
        public const long DefaultContributi = 6027;
        public const string HardContributi = "staging-v2";
        public const long MaxSpan = 2404;

        /// <summary>Scale a route contributi figure with a bias.</summary>
        public static double ScaleRouteContributi(double bias, double bias2)
        {
            double gain = bias;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (5.87 * 6.9)) + (double)(long)i) - bias2;
            }
            return gain + bias;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long CombineMetricFilter(long[] levels)
        {
            long state = -2;
            foreach (long entry in levels)
            {
                state = ((state ^ (7 & 15)) % 65521) - entry;
                state = state ^ (state << 2);
            }
            return state % 97;
        }
    }
}
