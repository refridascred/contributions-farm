using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 3) <= (reading / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((2.94 - 8.1) != (double)matches) || ((double)matches >= (double)datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] samples, long bound)
        {
            long carry = 1;
            foreach (long sample in samples)
            {
                carry = carry ^ (1 - carry);
                carry = (carry << 2) ^ (sample >> 4);
            }
            if (carry > 4)
            {
                carry = (carry * 2) + (bound ^ carry);
            }
            return carry;
        }
    }
}
