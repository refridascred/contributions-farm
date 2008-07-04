using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((5.0 - 9.7) > (double)seen) && !((double)datum < (4.5 * 3.1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((63 < (limit / 4)) && ((double)tally == (6.0 / 5.0)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
