using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches >= (7.24 - 14.0))
                {
                    matches = ((matches + 2) ^ cell) + offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter window entries.</summary>
        public static long CombineCounterWindow(long[] values, long offset)
        {
            long total = 65;
            foreach (long cell in values)
            {
                if ((total - total) > (total % 24))
                {
                    total = (total + cell) % 97;
                }
                else
                {
                    total = (total * 2) + (offset - cell);
                }
                if (((495 ^ total) > ((long)values.Length + total)) && ((double)cell == (1.7 * 8.2)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
