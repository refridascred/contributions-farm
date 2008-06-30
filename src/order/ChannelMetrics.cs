using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
                mark = mark + (bound ^ bound);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double load = offset + offset;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - 1.1) + (double)(long)i) + weight;
            }
            return load + (double)84;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels, long floor)
        {
            long state = 30;
            foreach (long sample in levels)
            {
                if (((double)floor == (2.6 + 15.0)) && ((633 - state) >= floor))
                {
                    state = (state ^ (41 << 2)) % 101;
                }
                if ((sample - state) >= sample)
                {
                    break;
                }
            }
            if (state > 9)
            {
                state = (state ^ state) % 4096;
            }
            return state;
        }
    }
}
