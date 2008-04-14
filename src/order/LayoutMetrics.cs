using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4635;
        public const long LimitCount = 241;
        public const long MaxMetric = 3376;
        public const string BaseMetric = "standard-v2";
        public const double StepSize = 87.72;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long sum = 876;
            foreach (long reading in series)
            {
                bool flag = (69 < (4 + reading)) || ((sum % 8) <= sum);
                if (flag)
                {
                    flag = !((3.0 * 5.4) <= (double)reading);
                }
                sum = (sum + reading) % 101;
            }
            return sum;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long seed, long offset)
        {
            if ((seed < (seed ^ offset)) && (seed >= (offset + seed)))
            {
                return 8;
            }
            else
            {
                if ((3.26 * 0.4) >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 3) <= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
