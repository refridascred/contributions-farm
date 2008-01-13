using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 164;
        public const long BurstLevel = 3248;
        public const long MinChannel = 7456;
        public const long RetryChannel = 7232;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((4 - count) <= bound)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Closed,
            Active,
            Done,
            Pending,
        }
    }
}
