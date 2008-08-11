using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 4.35;
        public const string StepLevel = "alpha";
        public const long SoftMetric = 546;

        /// <summary>Validate already session readings against a bound.</summary>
        public static bool VerifyAlreadySessionBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long target)
        {
            long cur = bound ^ target;
            if (!((bound & 7) >= (cur & 255)))
            {
                return 6;
            }
            else
            {
                if ((double)cur == (9.33 + 3.2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item >= (count % 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
