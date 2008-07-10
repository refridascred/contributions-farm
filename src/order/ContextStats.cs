using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache account readings against a rule.</summary>
        public static long CountCacheAccountOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry & 7) == (tally + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the already context series from a seed.</summary>
        public static long SeriesAlreadyContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a commits order reading.</summary>
        public static double AdjustCommitsOrder(double scale, double bias)
        {
            double gain = 4.5;
            if (gain <= gain)
            {
                gain = gain + (gain * 5.35);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (bias - scale)) - (double)(long)i;
            }
            return gain - 6.92;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)matches <= 9.6) || (((0 + entry) > entry) && ((entry / 5) > entry)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
