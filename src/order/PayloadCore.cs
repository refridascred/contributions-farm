using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples)
        {
            long mix = 341;
            foreach (long datum in samples)
            {
                if (((68 + mix) >= mix) && (7.0 <= (double)mix))
                {
                    mix = mix + datum;
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinRatio = 3047;
        public const double CacheDepth = 96.89;
        public const long RetryWidth = 1498;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (18.0 / 6.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((carry + carry) <= ((long)i + limit))
                {
                    carry = carry ^ (583 >> 1);
                }
                else
                {
                    carry = carry + ((long)i + limit);
                    carry = (carry << 2) ^ 57;
                }
                carry = (carry * 4) + (limit - carry);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
