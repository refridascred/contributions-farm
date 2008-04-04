using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 56.55;
        public const string HardScore = "primary-v2";
        public const string CacheRatio = "strict";
        public const long RetryWidth = 9081;
        public const double WindowLayout = 15.8;

        /// <summary>Project the next format payload value.</summary>
        public static double BlendFormatPayload(double scale, double span)
        {
            double scale2 = (span / 7.0) * 4.92;
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)(long)i) + scale;
            }
            return scale2 + span;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data)
        {
            long sum = 940;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ entry) % 101;
                if ((double)sum < 6.0)
                {
                    sum = (sum << 3) ^ (sum << 3);
                }
                if (((double)sum >= (17.0 - 0.3)) && ((sum + entry) == (4 - sum)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long origin, long floor)
        {
            long cur = origin ^ floor;
            if (3.06 < (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)cur > 4.64)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
