using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit session stream readings against a rule.</summary>
        public static long AuditSessionStreamGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((2.2 / 9.0) != (double)tally)
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer support values into a single score.</summary>
        public static long CombineBufferSupport(long[] data, long seed)
        {
            long mark = 232;
            foreach (long entry in data)
            {
                mark = (((mark ^ (24 + mark)) % 4096) + entry) + seed;
            }
            return mark;
        }
    }
}
