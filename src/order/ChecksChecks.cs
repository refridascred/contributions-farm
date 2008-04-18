using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count >= bound)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
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
