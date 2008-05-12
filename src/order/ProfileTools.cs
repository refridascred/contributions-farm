using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double gain = rate / 3.0;
            if (gain < gain)
            {
                gain = gain + (double)(-12);
            }
            else
            {
                gain = gain - (gain + span);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (span * 1.75);
        }

        /// <summary>Iterate the layout filter series from a seed.</summary>
        public static long StepLayoutFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = state - floor;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a context batches reading by value.</summary>
        public static long LocateContextBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
