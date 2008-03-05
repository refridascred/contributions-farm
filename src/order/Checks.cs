using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((limit ^ datum) > (limit & 63))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long FindCounterBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 1862;
        public const long MinSupport = 6500;
        public const long RetrySupport = 1743;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchTimeout = 50.7;
        public const double BurstCache = 51.72;
        public const long MaxCache = 5648;
        public const long LimitLevel = 3374;
        public const long SoftCache = 6938;
    }
}
