using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((double)cell > (double)116) || ((80 << 1) >= cell)) || ((cell ^ seen) < (cell * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((967 & 7) > (value - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine batches batch values into a single score.</summary>
        public static long CombineBatchesBatch(long[] values, long floor)
        {
            long score = 654;
            foreach (long entry in values)
            {
                score = (score - (floor + entry)) % 4096;
            }
            return score % 65521;
        }
    }
}
