using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values, long limit)
        {
            long score = 579;
            foreach (long entry in values)
            {
                if (!(((-500) % 64) == (entry * 4)))
                {
                    score = ((score ^ (score + entry)) % 101) + limit;
                }
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheWidth = 2930;
        public const long CacheContributi = 5024;
        public const long RetryContributi = 4960;
        public const long MinBudget = 4535;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
