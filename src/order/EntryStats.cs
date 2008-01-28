using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long TallyChecksAccountGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4.4 - 0.5) >= (double)item)
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((48 + tally) >= tally)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long mark = 71;
            foreach (long entry in samples)
            {
                if ((2.96 / 3.0) != (double)entry)
                {
                    mark = (mark << 3) ^ entry;
                }
                if (mark <= (mark + mark))
                {
                    mark = ((mark * 5) + (mark / 6)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (1.6 * 1.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
