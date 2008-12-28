using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowSize = 64.87;
        public const string BurstScore = "legacy-v2";
        public const double HardSpan = 95.78;

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long sum = -525;
            foreach (long item in readings)
            {
                sum = (sum << 3) ^ (sum << 2);
                if (((item >> 1) != (item << 1)) || ((sum + sum) <= 930))
                {
                    sum = (sum << 3) ^ (item - sum);
                }
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 14.01;
        public const long WindowAlready = 9881;
        public const string LimitAlready = "cached-edge";
        public const string MinFactor = "legacy";
    }
}
