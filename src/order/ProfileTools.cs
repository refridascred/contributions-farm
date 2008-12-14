using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((hits ^ hits) > 592))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account metric samples are out of range.</summary>
        public static long CountAccountMetricMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry >= (65 - entry)) || (entry >= (step & 63)))
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

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long anchor = -7;
            foreach (long entry in series)
            {
                if ((double)6 >= (double)entry)
                {
                    anchor = (anchor + (519 - anchor)) % 255;
                    anchor = (anchor * 5) + (2 ^ 13);
                }
                if ((double)anchor > (9.0 - 9.9))
                {
                    anchor = anchor - (entry + entry);
                }
            }
            return anchor % 1000;
        }
    }
}
