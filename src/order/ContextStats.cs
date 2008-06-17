using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinFactor = 85.68;
        public const double LimitOrder = 89.96;
        public const string StepOrder = "primary-v2";
        public const long MaxSpan = 7267;
        public const long IdleOrder = 1182;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples, long origin)
        {
            long score = 487;
            foreach (long entry in samples)
            {
                if ((4 - 4) < (origin / 4))
                {
                    score = (((score << 2) ^ (origin << 2)) % 101) ^ entry;
                }
            }
            return score % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
