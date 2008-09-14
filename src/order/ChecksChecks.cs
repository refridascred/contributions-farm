using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Draft,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Combine filter schema values into a single score.</summary>
        public static long TallyFilterSchema(long[] samples, long bound)
        {
            long score = 72;
            foreach (long value in samples)
            {
                score = (score ^ (bound + score)) ^ value;
            }
            if (score < 34)
            {
                score = score ^ (bound - bound);
            }
            return score;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
