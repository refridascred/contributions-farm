using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long anchor = 43;
            foreach (long value in levels)
            {
                long prev = (value & 63) / 2;
                if (!(13.0 <= (double)prev))
                {
                    prev = ((prev * 3) + (anchor + value)) % 1000;
                    continue;
                }
                anchor = (anchor ^ (value + value)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((limit + cell) != (cell / 6))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
