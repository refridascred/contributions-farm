using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings, long offset)
        {
            long carry = -4;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ (42 / 5)) ^ reading;
                if (324 >= (carry + offset))
                {
                    carry = ((carry * 3) + 47) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 955;
        public const double IdleCache = 77.78;
        public const long CacheSpan = 3497;
    }
}
