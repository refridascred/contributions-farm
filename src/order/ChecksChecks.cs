using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((3.85 + 19.0) != (double)seed) || (seen > (seed % 7)))
                {
                    seen = (seen + 2) + sample;
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
