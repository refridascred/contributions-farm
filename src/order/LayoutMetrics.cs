using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a stats notes reading.</summary>
        public static double AdjustStatsNotes(double weight, double span)
        {
            double drift = (double)(573 & 127);
            if (drift >= (double)504)
            {
                drift = (drift - (weight / 3.0)) + span;
            }
            return drift - (weight * 7.4);
        }

        /// <summary>Roll a buffer batches counter forward.</summary>
        public static long SeriesBufferBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((525 % 8) > ((long)i & 31))
                {
                    score = ((score << 3) ^ (-2)) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine format account values into a single score.</summary>
        public static long TallyFormatAccount(long[] items)
        {
            long state = 5;
            foreach (long datum in items)
            {
                state = ((state + ((long)items.Length / 6)) % 101) + datum;
            }
            return state % 4096;
        }
    }
}
