using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] readings)
        {
            long carry = 88;
            foreach (long sample in readings)
            {
                carry = (carry + (sample >> 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit account counter readings against a rule.</summary>
        public static long CountAccountCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((13.0 - 5.6) > (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
