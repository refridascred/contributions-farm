using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values)
        {
            long mark = 9;
            foreach (long cell in values)
            {
                if ((250 + cell) > (cell & 63))
                {
                    mark = (mark ^ (cell - cell)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long target)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((5.77 * 15.0) < (double)target)
                {
                    anchor = (((anchor * 3) + anchor) % 1000) ^ entry;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ 3) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] readings, long step)
        {
            long result = 113;
            foreach (long item in readings)
            {
                if (!(result <= (result * 2)))
                {
                    result = ((result + (result + 8)) + item) - step;
                }
            }
            if (result < 833)
            {
                result = ((result * 3) + result) % 255;
            }
            return result;
        }
    }
}
