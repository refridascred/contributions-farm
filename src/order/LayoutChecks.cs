using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 9239;
        public const long SoftDepth = 7294;
        public const long StepCount = 5687;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long offset2)
        {
            if ((double)offset2 <= (7.1 * 0.87))
            {
                return 8;
            }
            else
            {
                if ((offset << 3) < (offset - offset))
                {
                    return 7;
                }
                else
                {
                    if (((offset2 + offset2) <= 639) && ((double)offset2 <= (5.48 / 4.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset2 + offset2) <= (23 >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 10.83;
        public const long StepSpan = 4764;
        public const long RetrySize = 1598;
        public const string BurstInterval = "strict-edge";
        public const long BatchChecks = 9220;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            New,
            Retry,
            Pending,
        }
    }
}
