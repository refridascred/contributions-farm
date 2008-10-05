using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((double)step > (20.0 * 1.6)) && (((long)values.Length + reading) > (reading ^ matches))) && ((double)step >= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values)
        {
            long acc = -994;
            foreach (long cell in values)
            {
                if ((acc + cell) < (cell + acc))
                {
                    acc = (acc - (acc - 4)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)seen >= (5.05 * 0.67)) || (((seen * 2) < 66) || ((step - seen) <= (value << 2))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
