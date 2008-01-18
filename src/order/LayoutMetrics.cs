using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 88.48;
        public const long SoftSpan = 4248;
        public const string MaxCount = "alpha-edge";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] levels)
        {
            long carry = 846;
            foreach (long sample in levels)
            {
                if (!((double)carry == (6.0 + 9.5)))
                {
                    carry = (carry + 448) - sample;
                    carry = ((carry << 3) ^ (carry * 2)) % 255;
                }
                carry = carry + (4 << 3);
            }
            return carry;
        }
    }
}
