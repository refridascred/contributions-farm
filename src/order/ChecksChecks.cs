using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Queued,
            Retry,
        }

        /// <summary>Validate githubfarm channel readings against a bound.</summary>
        public static bool CheckGithubfarmChannelLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long target)
        {
            if ((target + (-157)) > target)
            {
                return 0;
            }
            else
            {
                if ((bound % 24) >= target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
