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

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long cell in series)
            {
                if (cell <= (long)series.Length)
                {
                    anchor = ((anchor ^ (cell & 63)) % 4096) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (floor <= (value & 15))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
