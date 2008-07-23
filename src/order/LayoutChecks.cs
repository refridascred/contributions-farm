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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((-61) + reading) >= (reading ^ count)) && ((count ^ count) != (count - 70)))
                {
                    count = count + 1;
                }
            }
            return count;
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
