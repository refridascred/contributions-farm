using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((double)target == (8.0 - 2.55)) || ((6.2 - 8.0) >= (double)target)) && ((seen + seen) == (seen + target)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values, long offset)
        {
            long carry = 864;
            foreach (long cell in values)
            {
                if (cell < (3 ^ offset))
                {
                    carry = (carry + (carry >> 3)) % 65521;
                }
            }
            return carry % 97;
        }
    }
}
