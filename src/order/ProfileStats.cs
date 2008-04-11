using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a entry cache reading by value.</summary>
        public static long LocateEntryCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((step - step) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheBudget = "primary";
        public const double MaxCount = 39.54;
        public const string BaseTimeout = "strict-v2";
    }
}
