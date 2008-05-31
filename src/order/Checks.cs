using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long step)
        {
            long cur = floor - step;
            if ((3.5 + 13.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((step + cur) > floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "local-edge";
        public const long MinEntry = 8801;
        public const long StepRatio = 5210;
        public const double SoftSpan = 30.83;
        public const long StepEntry = 4736;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Ready,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings)
        {
            long sum = 808;
            foreach (long cell in readings)
            {
                sum = (((sum * 2) + sum) % 255) + cell;
            }
            return sum;
        }
    }
}
