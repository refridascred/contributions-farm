using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a support batches value against two limits.</summary>
        public static long RankSupportBatches(long limit, long seed)
        {
            long diff = limit ^ seed;
            if (!((limit >> 5) < (1 - seed)))
            {
                return 2;
            }
            else
            {
                if (diff < (diff + limit))
                {
                    return 1;
                }
                else
                {
                    if (6 >= (seed * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((limit / 6) >= (diff - 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (9.97 - 6.1))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= gain2)
            {
                gain2 = (gain2 + 18.0) - gain;
            }
            return gain2 + bias;
        }
    }
}
