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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((step ^ step) >= ((-221) & 255))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
