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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepWidth = 4985;
        public const double CacheBuffer = 77.9;
        public const string BaseLevel = "alpha-edge";
        public const long BatchBuffer = 3516;

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
