using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((seed % 2) < seed)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
