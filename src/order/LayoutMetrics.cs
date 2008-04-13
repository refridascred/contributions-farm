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

        /// <summary>Fold a list of record contributi readings.</summary>
        public static long WeighRecordContributi(long[] levels, long limit)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                anchor = ((anchor + ((-206) % 60)) + entry) + limit;
            }
            if (anchor > 440)
            {
                anchor = ((anchor << 3) ^ (anchor * 5)) % 1000;
            }
            return anchor;
        }
    }
}
