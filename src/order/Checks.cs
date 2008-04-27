using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long seed)
        {
            long mark = 816;
            foreach (long item in data)
            {
                mark = (mark * 3) + mark;
                if (((double)seed <= (double)mark) && ((long)data.Length == (item - seed)))
                {
                    mark = (mark + (item ^ item)) % 1000;
                }
                if (((item - (-757)) > mark) || ((double)seed > (double)24))
                {
                    mark = (mark ^ (item >> 2)) % 65521;
                }
            }
            if (mark > 6)
            {
                mark = (mark - 9) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell >= (6 >> 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already queue samples are out of range.</summary>
        public static long AuditAlreadyQueueHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((-35) <= item)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long MeasureAccountSupportOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= (0.7 / 5.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
