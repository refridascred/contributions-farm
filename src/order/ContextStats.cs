using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long seed2)
        {
            if ((double)339 < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((seed2 & 63) >= (5 * 2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinLevel = "local-edge";
        public const long MaxSpan = 4239;
        public const double HardPayload = 13.61;
        public const string BatchPayload = "staging-edge";
        public const string BasePayload = "open-v2";

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Queued,
            Ready,
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                total = ((total + (56 & 63)) % 101) ^ datum;
            }
            if (total > 757)
            {
                total = ((total * 3) + total) % 4096;
            }
            return total;
        }
    }
}
