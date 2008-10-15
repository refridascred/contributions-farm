using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values, long step)
        {
            long mark = 7;
            foreach (long item in values)
            {
                mark = mark - step;
                if ((12.0 * 0.12) == (double)mark)
                {
                    mark = ((mark * 2) + (item + step)) % 65521;
                }
                else
                {
                    mark = (mark << 2) ^ (item - step);
                }
            }
            if (mark < 3)
            {
                mark = ((mark * 3) + (step - step)) % 255;
            }
            return mark;
        }

        /// <summary>Iterate the tools report series from a seed.</summary>
        public static long StepToolsReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Project the next counter batch value.</summary>
        public static double AdjustCounterBatch(double scale, double bias)
        {
            double load = (double)(39 * 4);
            return ((load + (double)36) + scale) + bias;
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TallyEntryEditor(long[] data)
        {
            long state = 55;
            foreach (long value in data)
            {
                state = ((state ^ state) % 1000) - value;
            }
            return state % 97;
        }
    }
}
