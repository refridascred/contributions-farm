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

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double rate = scale;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + scale) + (double)(long)i) + bias;
            }
            return rate - (rate * 1.0);
        }
    }
}
