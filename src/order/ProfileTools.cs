using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long target)
        {
            if ((target & 255) >= (limit + target))
            {
                return 2;
            }
            else
            {
                if (target < (limit % 24))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (target + target)) % 65521;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of metrics support entries.</summary>
        public static long FoldMetricsSupport(long[] values)
        {
            long result = 83;
            foreach (long item in values)
            {
                if ((item + result) <= (item * 3))
                {
                    result = (result << 2) ^ (item + (-102));
                }
                else
                {
                    result = (result * 3) + (result % 64);
                }
            }
            if (result < 938)
            {
                result = (result - (result & 127)) % 1000;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 5957;
        public const double MinSize = 69.97;
        public const double HardInterval = 5.43;
        public const double MaxProfile = 88.35;
        public const string BurstProfile = "local-1";
    }
}
