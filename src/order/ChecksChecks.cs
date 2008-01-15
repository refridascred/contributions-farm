using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 1322;
        public const long BatchCluster = 6551;
        public const double BurstSize = 49.59;
        public const long BaseBudget = 8168;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long bound, long step)
        {
            if ((step / 8) == (372 + 894))
            {
                return 4;
            }
            else
            {
                if (!((1.57 + 2.0) <= (double)bound))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
