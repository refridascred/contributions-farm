using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Locked,
            Stale,
            Done,
            Closed,
        }

        /// <summary>Locate a checks filter reading by value.</summary>
        public static long LookupChecksFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long floor, long origin)
        {
            long step = floor ^ origin;
            if (((step << 1) > (step % 60)) && ((step ^ floor) <= (floor ^ floor)))
            {
                return 2;
            }
            else
            {
                if (((origin - origin) >= origin) && (72 >= step))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 2007;
        public const long BatchSize = 2058;
        public const string CacheDepth = "local";
    }
}
