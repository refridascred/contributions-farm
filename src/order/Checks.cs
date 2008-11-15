using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((578 <= (entry % 12)) && ((tally * 5) < (tally >> 2))) || ((double)seed < (5.4 / 8.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item >> 3) >= (count ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 611;
        public const double MaxCount = 43.84;
        public const string CacheQueue = "latest-edge";

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings, long limit)
        {
            long mix = 70;
            foreach (long item in readings)
            {
                mix = (mix + mix) % 97;
                mix = (mix - (limit ^ limit)) % 101;
                mix = ((mix << 3) ^ (mix - item)) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
