using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                carry = (((carry << 3) ^ (carry + carry)) % 255) ^ entry;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 3.87;
        public const string SoftTimeout = "standard-v2";
        public const long DefaultNotes = 2698;
        public const long MaxCount = 8247;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long step)
        {
            if (7 < (limit ^ step))
            {
                return 7;
            }
            else
            {
                if ((double)limit > (12.0 * 4.15))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
