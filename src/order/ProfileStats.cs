using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the account filter entries that pass the check.</summary>
        public static long CountAccountFilterHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample << 2) != (sample + 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((origin + origin) > (count + 571))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed + matches) > matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                if ((26 + (-1)) <= (anchor << 1))
                {
                    long tally = anchor;
                    anchor = (anchor + tally) % 97;
                }
                anchor = (anchor * 5) + (entry - entry);
            }
            if (anchor > 0)
            {
                anchor = ((anchor << 3) ^ (anchor << 3)) % 65521;
            }
            return anchor;
        }
    }
}
