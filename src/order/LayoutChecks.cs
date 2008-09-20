using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster account samples are out of range.</summary>
        public static long AuditClusterAccountMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((7.9 - 20.0) != (double)(long)values.Length)
                {
                    count = ((count + 3) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((sample - sample) != (sample % 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (total * 4)) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((6.0 + 6.8) <= (double)count) || !((count ^ count) > count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
