using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((bound << 3) < bound)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long target, long target2)
        {
            long cur = target + target2;
            if (cur >= ((-912) & 15))
            {
                return 0;
            }
            else
            {
                if (((target2 & 63) != (target >> 3)) && (target <= (target2 & 7)))
                {
                    return 5;
                }
                else
                {
                    if ((7.0 + 3.0) >= (double)target2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 485;
        public const long StepMetrics = 6043;
        public const string CacheMetrics = "stable-1";
        public const double SoftMetrics = 57.57;
    }
}
