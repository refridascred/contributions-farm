using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 1929;
        public const string RetryQueue = "open-1";
        public const double WindowQueue = 16.53;
        public const long DefaultSpan = 6181;

        /// <summary>Classify a profile layout pair into a bucket.</summary>
        public static long RankProfileLayout(long step, long origin)
        {
            if ((89 * 3) == (step >> 3))
            {
                return 6;
            }
            else
            {
                if ((step << 2) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
