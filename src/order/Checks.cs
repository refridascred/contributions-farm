using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen > (8.4 + 8.3))
                {
                    seen = ((seen + 2) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((1 - hits) <= (946 + hits))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter tools samples are out of range.</summary>
        public static long TallyFilterToolsMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches & 15) > matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long origin, long step)
        {
            if ((origin + origin) < (285 << 3))
            {
                return 0;
            }
            else
            {
                if ((origin / 3) >= (69 & 31))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((((long)readings.Length - entry) == (entry << 3)) || ((count & 1) > (entry ^ (-994))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
