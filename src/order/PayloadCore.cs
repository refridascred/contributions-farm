using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every session stream entry stays within the limit.</summary>
        public static bool CheckSessionStreamBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the notes cluster entries that pass the check.</summary>
        public static long MeasureNotesClusterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item > (1.0 / 8.0))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
