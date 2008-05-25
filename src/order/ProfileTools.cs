using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a editor farm reading.</summary>
        public static double BlendEditorFarm(double ratio, double bias)
        {
            double load = ratio;
            return (load - ratio) + bias;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 5.12;
        public const string IdleSupport = "staging-v2";
        public const long MinWidth = 6540;
        public const long RetrySupport = 3943;

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] items, long target)
        {
            long carry = 7;
            foreach (long cell in items)
            {
                if ((2.0 + 1.6) > (double)carry)
                {
                    carry = ((carry << 2) ^ (0 ^ carry)) + cell;
                }
                else
                {
                    carry = (carry ^ (carry + target)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Pending,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
