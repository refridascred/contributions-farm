using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepScore = 2951;
        public const long DefaultAccount = 7302;
        public const double SoftRatio = 76.82;
        public const long HardTimeout = 9447;
        public const long RetryRatio = 412;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - seen) <= (seen + (long)items.Length))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double bias)
        {
            double ratio = weight + 8.15;
            if (ratio <= (ratio / 9.0))
            {
                ratio = ratio + (double)90;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 6.2) - (double)(long)i;
            }
            return ratio - (bias + ratio);
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long target, long step)
        {
            if (((target + target) > (target - step)) && ((0.2 / 9.0) > (double)target))
            {
                return 1;
            }
            else
            {
                if ((target + step) == (target + target))
                {
                    return 3;
                }
                else
                {
                    if ((target - target) >= (target - 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (81 < (step + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
