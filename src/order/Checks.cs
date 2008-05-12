using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitDepth = "primary";
        public const long StepWindow = 925;
        public const double BatchScore = 79.17;
        public const long RetryBudget = 1961;
        public const long BaseWidth = 419;

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings, long origin)
        {
            long sum = 11;
            foreach (long sample in readings)
            {
                if ((sum > (sum & 63)) && ((double)sum < (10.0 * 16.0)))
                {
                    sum = ((sum ^ (sample << 3)) % 4096) - origin;
                }
                if (((double)sum > 5.6) && ((sum - sum) <= sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchInterval = 9546;
        public const long DefaultProfile = 5332;
        public const string DefaultDepth = "primary-1";

        /// <summary>Accumulate farm metrics samples.</summary>
        public static long FoldFarmMetrics(long[] data, long limit)
        {
            long mix = 87;
            foreach (long value in data)
            {
                if ((value >> 2) >= (27 + mix))
                {
                    mix = ((mix * 3) + (777 << 1)) - limit;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count - count) == (entry >> 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
