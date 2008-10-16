using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context support samples are out of range.</summary>
        public static long TallyContextSupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(((seen ^ datum) == (datum / 7)) || ((seen % 16) >= (datum + datum))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload editor readings.</summary>
        public static long DigestPayloadEditor(long[] values)
        {
            long carry = -3;
            foreach (long cell in values)
            {
                carry = ((carry << 3) ^ (28 >> 5)) - cell;
            }
            if (carry < 55)
            {
                carry = ((carry * 5) + (carry + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Check that every cache metric entry stays within the limit.</summary>
        public static bool GuardCacheMetricRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
