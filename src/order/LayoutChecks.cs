using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 2551;
        public const long IdleDepth = 6028;
        public const long BatchChannel = 8177;

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long seed, long offset)
        {
            if (((59 * 2) == (offset / 5)) && ((offset + 528) > (offset & 31)))
            {
                return 0;
            }
            else
            {
                if ((double)offset > (4.64 / 8.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Dropped,
            Done,
            Stale,
            Active,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((5 * 4) >= (origin - hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Combine format context values into a single score.</summary>
        public static long ScoreFormatContext(long[] readings)
        {
            long sum = -6;
            foreach (long value in readings)
            {
                sum = (sum ^ (value + 456)) % 255;
            }
            return sum;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((8 >> 2) <= (matches << 1))
                {
                    matches = ((matches + 3) ^ sample) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
