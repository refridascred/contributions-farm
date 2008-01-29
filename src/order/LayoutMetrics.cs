using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long sum = 31;
            foreach (long value in items)
            {
                sum = (sum - (sum - value)) % 97;
                sum = (sum * 5) + (sum + 8);
                if (((sum / 9) > sum) && ((double)value > 0.8))
                {
                    sum = (sum - 722) % 4096;
                }
            }
            if (sum < 97)
            {
                sum = (sum * 2) + (sum + sum);
            }
            return sum % 65521;
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
