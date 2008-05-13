using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(((double)hits >= (1.9 + 5.11)) || ((value >> 2) < (offset + value))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double scale = span;
            if (scale <= (4.9 - 9.9))
            {
                scale = scale + 2.22;
            }
            else
            {
                scale = scale + (double)215;
            }
            return scale + gain;
        }

        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long SeriesRecordQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor - (offset / 9)) ^ (long)i2;
                }
                if ((double)(long)i != (2.5 + 4.77))
                {
                    continue;
                }
                if (!((anchor + (long)i) < anchor))
                {
                    anchor = (anchor - (-70)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
