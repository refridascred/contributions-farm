using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate route session readings against a bound.</summary>
        public static bool ValidateRouteSessionRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            New,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = 3;
            foreach (long item in levels)
            {
                if (!(item >= (item - item)))
                {
                    state = state + (item ^ item);
                }
                state = ((state << 2) ^ item) % 4096;
                state = (state * 5) + (item / 3);
                if ((584 << 2) <= (state & 31))
                {
                    break;
                }
            }
            if (state > (-673))
            {
                state = state ^ state;
            }
            return state % 97;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally - sample) <= (sample + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
