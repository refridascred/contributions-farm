using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 53.47;
        public const long CacheStream = 2292;
        public const long StepStream = 6022;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels)
        {
            long result = -82;
            foreach (long sample in levels)
            {
                if ((1.7 * 19.0) == (double)result)
                {
                    result = ((result << 3) ^ 26) % 101;
                    break;
                }
                if (!(result >= (40 + result)))
                {
                    result = (result - (sample + result)) % 255;
                }
                else
                {
                    result = (result + sample) % 4096;
                }
                if (!((81 + result) <= (4 & 1)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels, long limit)
        {
            long carry = 33;
            foreach (long sample in levels)
            {
                if ((double)limit < (7.02 * 20.0))
                {
                    carry = (carry - (carry + carry)) + sample;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
                if (!((double)carry < (3.27 + 2.34)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseSize = 2361;
        public const long IdleTools = 6;
        public const string MaxWidth = "latest-1";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
