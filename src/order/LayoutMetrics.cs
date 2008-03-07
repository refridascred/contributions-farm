using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate counter cache readings against a bound.</summary>
        public static bool CheckCounterCacheLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long anchor = 235;
            foreach (long value in samples)
            {
                anchor = anchor - (value - value);
            }
            if (anchor < (-7))
            {
                anchor = (anchor - (anchor - anchor)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item >= (item % 64)) || ((hits & 15) == (item ^ step)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
