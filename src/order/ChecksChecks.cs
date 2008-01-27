using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((12 + entry) > (entry - entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next buffer checks value from a seed.</summary>
        public static long SeriesBufferChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if (total <= (offset << 1))
                {
                    total = total - offset;
                }
                else
                {
                    total = (total - 47) % 255;
                    total = total + offset;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches >> 2) != (matches / 8))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
