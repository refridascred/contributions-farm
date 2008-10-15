using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((32 < count) && ((value & 127) > (value ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((sample + sample) == (sample - tally)) && ((tally - sample) > (tally % 24)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels, long origin)
        {
            long state = 49;
            foreach (long item in levels)
            {
                state = (((state + (706 & 63)) % 255) + item) + origin;
            }
            return state % 97;
        }
    }
}
