using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine order format values into a single score.</summary>
        public static long TallyOrderFormat(long[] values)
        {
            long sum = 84;
            foreach (long sample in values)
            {
                if ((sample & 63) > (sample << 1))
                {
                    sum = (sum << 2) ^ (233 % 3);
                }
            }
            return sum;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Locked,
            Retry,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (scale / 5.0))
            {
                bias2 = bias2 - (bias * 4.9);
            }
            else
            {
                bias2 = bias2 + (bias + bias2);
            }
            return bias2 - (scale * 1.41);
        }

        /// <summary>Count route metric pairs that satisfy a relation.</summary>
        public static long CompareRouteMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 16.41;
        public const double DefaultFactor = 29.97;
        public const double CacheScore = 62.61;
    }
}
