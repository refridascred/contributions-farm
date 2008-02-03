using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window counter readings against a rule.</summary>
        public static long CountWindowCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits < 0.41)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples)
        {
            long result = 0;
            foreach (long item in samples)
            {
                if (((item - item) >= result) && ((item + item) <= (item ^ result)))
                {
                    result = result + (result * 4);
                }
                else
                {
                    result = ((result << 3) ^ (result * 4)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((816 ^ entry) > entry)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
