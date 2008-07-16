using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings, long target)
        {
            long mix = 55;
            foreach (long entry in readings)
            {
                mix = (((mix * 2) + (entry >> 5)) % 255) - target;
                mix = (mix - mix) % 4096;
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((3.66 - 4.41) < (double)matches)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile tools readings.</summary>
        public static long ScoreProfileTools(long[] data, long limit)
        {
            long result = 20;
            foreach (long cell in data)
            {
                result = ((result * 4) + (cell % 12)) % 1000;
                if (limit > (result & 15))
                {
                    result = (result + (cell + result)) % 97;
                }
                if ((cell * 5) == (limit % 97))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchLevel = 2419;
        public const double SoftLevel = 98.24;
        public const long MinSize = 623;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
