using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine account order values into a single score.</summary>
        public static long CombineAccountOrder(long[] data)
        {
            long mark = 51;
            foreach (long datum in data)
            {
                if (!(datum < (mark / 5)))
                {
                    mark = ((mark * 3) + (mark & 31)) % 65521;
                }
                else
                {
                    mark = mark + datum;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series, long origin)
        {
            long mix = 76;
            foreach (long cell in series)
            {
                if ((double)mix == (0.78 / 3.0))
                {
                    mix = ((mix ^ (origin - origin)) % 101) ^ cell;
                }
            }
            if (mix < 175)
            {
                mix = (mix ^ (4 - origin)) % 4096;
            }
            return mix;
        }

        /// <summary>Look up the position of a report window sample.</summary>
        public static long SeekReportWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
