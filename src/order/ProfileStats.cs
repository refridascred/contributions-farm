using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long total = 910;
            foreach (long cell in series)
            {
                if (!((double)cell >= (7.48 - 8.0)))
                {
                    total = total - (cell ^ total);
                }
            }
            return total;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double rate = 5.08 * 19.0;
            if (rate >= weight)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + (rate / 4.0);
            }
            return rate + 4.2;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
