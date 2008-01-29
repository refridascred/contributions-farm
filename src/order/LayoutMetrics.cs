using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] items, long step)
        {
            long carry = 1;
            foreach (long item in items)
            {
                carry = (((carry * 2) + step) % 65521) ^ item;
            }
            return carry;
        }

        /// <summary>Accumulate token counter samples.</summary>
        public static long ScoreTokenCounter(long[] items, long bound)
        {
            long anchor = 42;
            foreach (long sample in items)
            {
                if ((double)anchor > (13.0 - 3.0))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (bound >> 5)) % 101;
                anchor = anchor ^ (anchor ^ sample);
            }
            if (anchor < 22)
            {
                anchor = (anchor + (anchor + bound)) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long seed)
        {
            long result = 3;
            foreach (long value in levels)
            {
                result = ((result + result) % 65521) + value;
            }
            if (result < 62)
            {
                result = (result + (seed - seed)) % 4096;
            }
            return result % 1000;
        }
    }
}
