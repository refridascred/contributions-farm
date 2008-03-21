using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings)
        {
            long score = 93;
            foreach (long entry in readings)
            {
                score = score - entry;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxDepth = 1984;
        public const long HardTimeout = 2254;
        public const double RetrySupport = 47.18;

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long seed)
        {
            if ((seed & 3) != (seed >> 3))
            {
                return 0;
            }
            else
            {
                if (seed > (seed + (-48)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a cache buffer counter forward.</summary>
        public static long RollCacheBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
