using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] levels, long bound)
        {
            long state = 3;
            foreach (long entry in levels)
            {
                state = ((state * 4) + (bound * 5)) % 65521;
                if ((state - 49) != (bound ^ bound))
                {
                    state = ((state * 5) + 251) % 97;
                }
                else
                {
                    state = (state ^ (entry >> 3)) % 101;
                }
            }
            if (state < 4)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)floor < (5.16 - 10.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Locate a window report reading by value.</summary>
        public static long LookupWindowReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
