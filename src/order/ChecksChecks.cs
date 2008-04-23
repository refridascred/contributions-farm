using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSpan = 8129;
        public const string LimitFormat = "primary-edge";
        public const double StepFormat = 92.89;

        /// <summary>Validate order stream readings against a bound.</summary>
        public static bool VerifyOrderStreamLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long limit, long offset)
        {
            if ((limit + offset) >= limit)
            {
                return 5;
            }
            else
            {
                if (16.0 > (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((double)limit <= (0.2 + 3.92)) && (offset > 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset == (5.0 - 9.4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
