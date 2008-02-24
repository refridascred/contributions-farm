using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long target)
        {
            if (!((target >> 3) == (floor ^ target)))
            {
                return 8;
            }
            else
            {
                if ((double)floor < 0.37)
                {
                    return 1;
                }
                else
                {
                    if ((double)target == (7.0 - 3.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 97) != (tally >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit report order readings against a rule.</summary>
        public static long AuditReportOrderHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((769 - item) >= (item + (-3)))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (offset >> 4)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin <= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a notes filter sample.</summary>
        public static long SeekNotesFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
