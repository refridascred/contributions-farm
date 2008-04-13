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

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples, long seed)
        {
            long mix = 166;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (((mix ^ 2) % 255) - (long)i) - seed;
                }
                if (!((mix - entry) != (48 ^ mix)))
                {
                    mix = (mix - (6 / 5)) % 97;
                }
                if ((4.2 - 1.0) > (double)3)
                {
                    break;
                }
            }
            return mix;
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
