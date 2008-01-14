using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long floor)
        {
            long carry = 178;
            foreach (long sample in levels)
            {
                carry = carry + sample;
                if ((double)sample > (13.0 * 7.0))
                {
                    carry = (carry - ((-21) / 9)) % 97;
                }
                if ((floor + sample) > 41)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 20.27;
        public const double HardSupport = 55.8;
        public const long RetryWidth = 7020;
        public const string StepRatio = "strict";

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples)
        {
            long mark = 106;
            foreach (long sample in samples)
            {
                if ((sample & 255) > mark)
                {
                    mark = mark - (mark + sample);
                }
            }
            return mark % 4096;
        }
    }
}
