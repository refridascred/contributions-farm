using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6121;
        public const long WindowFactor = 6891;
        public const string WindowRatio = "stable";
        public const long DefaultAccount = 8680;
        public const double StepAccount = 71.24;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long seed, long offset)
        {
            if (784 <= (26 + offset))
            {
                return 6;
            }
            else
            {
                if ((7 ^ offset) <= (seed << 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                if ((sample ^ 8) <= (origin + origin))
                {
                    mark = mark - (11 << 1);
                }
            }
            if (mark > 438)
            {
                mark = (mark << 2) ^ (mark * 5);
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Stale,
            New,
            Active,
            Paused,
            Synced,
        }

        /// <summary>Find the first window contributi entry that matches the target.</summary>
        public static long LocateWindowContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
