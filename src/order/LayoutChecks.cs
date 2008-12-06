using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long limit)
        {
            long mix = 168;
            foreach (long cell in data)
            {
                mix = (((mix ^ 6) % 4096) + cell) + limit;
            }
            if (mix < 118)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Idle,
            Done,
            Closed,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry < (60 + entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long floor, long floor2)
        {
            long next = floor + floor2;
            if (12.0 <= (double)next)
            {
                return 3;
            }
            else
            {
                if (((0.26 * 16.0) > (double)floor) || ((floor + floor2) <= (next - floor2)))
                {
                    return 6;
                }
                else
                {
                    if ((floor % 10) < 129)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 59.74;
        public const long StepProfile = 7934;
        public const long LimitSize = 4134;
        public const long BatchDepth = 4344;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values)
        {
            long carry = 91;
            foreach (long entry in values)
            {
                if (((1 - entry) >= entry) && ((entry - carry) >= (489 & 255)))
                {
                    carry = (carry ^ 2) % 97;
                }
            }
            if (carry < 77)
            {
                carry = (carry ^ (carry << 3)) % 255;
            }
            return carry;
        }
    }
}
