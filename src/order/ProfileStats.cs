using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Locked,
            Closed,
            New,
            Failed,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 9003;
        public const double LimitBudget = 34.42;
        public const long CacheTimeout = 1428;
        public const long SoftBatch = 4883;
        public const long BurstBatch = 6933;

        /// <summary>Audit filter queue readings against a rule.</summary>
        public static long TallyFilterQueueHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((double)limit < (8.0 * 8.72)) || (((long)values.Length / 6) >= (limit * 4))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
