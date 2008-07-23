using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSpan = 7565;
        public const string BurstSession = "standard-1";
        public const long WindowSession = 8512;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Locked,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Look up the position of a stats command sample.</summary>
        public static long FindStatsCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long step, long seed)
        {
            if ((44 % 64) < (9 - step))
            {
                return 5;
            }
            else
            {
                if ((double)step >= (2.8 + 3.5))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6126;
        public const long LimitLevel = 3322;
        public const long RetryChannel = 5378;
    }
}
