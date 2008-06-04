using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long offset)
        {
            if ((offset + offset) != (27 % 64))
            {
                return 0;
            }
            else
            {
                if ((bound & 3) <= offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ bound) == (7 / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset <= (5 << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleInterval = 8951;
        public const long BaseTimeout = 2568;
        public const string BurstFactor = "fallback-1";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally * 5) < value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats stream samples are out of range.</summary>
        public static long CountStatsStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((8 & 255) >= tally)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
