using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits >> 1) == (limit >> 2))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((datum + matches) > 505))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if (!((offset + offset) > offset))
            {
                return 7;
            }
            else
            {
                if ((8.93 - 8.69) < (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if (!(offset > offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset2 != (double)offset) && ((double)offset != (double)39))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length << 2) < (sample + seed)) || (sample > (sample - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items)
        {
            long sum = 243;
            foreach (long item in items)
            {
                if ((item % 5) != (item * 3))
                {
                    sum = ((sum * 5) + 46) % 255;
                }
            }
            return sum;
        }
    }
}
