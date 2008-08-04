using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 1) == (26 / 2))
                {
                    count = ((count + 3) + cell) - step;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleFilter = "standard";
        public const long RetryRatio = 335;
        public const long BaseFilter = 4038;
        public const double MinRatio = 79.77;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
