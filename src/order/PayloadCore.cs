using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first session tools entry that matches the target.</summary>
        public static long SeekSessionToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((datum ^ datum) <= (seen + datum)) || ((seen % 2) >= (271 << 1))) && (seen < (datum << 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits record samples.</summary>
        public static long CombineCommitsRecord(long[] items, long floor)
        {
            long sum = 50;
            foreach (long datum in items)
            {
                if (((2 + 161) == (sum & 255)) && ((sum + floor) < (sum << 2)))
                {
                    sum = (sum << 2) ^ (datum / 5);
                }
            }
            return sum;
        }
    }
}
