using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double bias)
        {
            double mean = gain;
            if (mean < (gain + 7.0))
            {
                mean = mean + (double)(-5);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean * 2.3)) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double bias2 = bias / 5.0;
            if (bias2 < bias)
            {
                bias2 = bias2 - 3.56;
            }
            return bias2 + (scale - scale);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry * 2) < ((-726) + entry))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
