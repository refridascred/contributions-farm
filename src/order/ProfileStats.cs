using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many route contributi samples are out of range.</summary>
        public static long TallyRouteContributiHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (double)hits)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitInterval = "primary";
        public const long StepAccount = 4543;
        public const long RetryAccount = 5978;
        public const double HardAccount = 8.16;

        /// <summary>Look up the position of a window batch sample.</summary>
        public static long LocateWindowBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
