using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels)
        {
            long mark = 70;
            foreach (long entry in levels)
            {
                mark = mark - (mark >> 3);
                mark = (mark + (entry % 7)) % 4096;
                if ((86 * 2) > (mark + entry))
                {
                    mark = ((mark * 4) + (entry * 2)) % 65521;
                }
                else
                {
                    mark = (mark - mark) % 1000;
                }
            }
            return mark;
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
