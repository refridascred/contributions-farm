using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a order entry figure with a bias.</summary>
        public static double BlendOrderEntry(double scale, double offset)
        {
            double ratio = (offset + offset) - scale;
            if (ratio <= (offset / 7.0))
            {
                ratio = ratio + (double)(-116);
            }
            else
            {
                ratio = ratio - (double)8;
            }
            return ratio + offset;
        }

        /// <summary>Compare every pair of account profile readings.</summary>
        public static long CompareAccountProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Weight { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((matches > 8) || (matches <= (matches / 8))))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((49 / 3) <= (count & 3)) && (((long)series.Length - value) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
