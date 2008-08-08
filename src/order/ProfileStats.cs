using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCount = "open-edge";
        public const double BatchCache = 50.57;
        public const long SoftBudget = 1200;
        public const long BaseRatio = 1840;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            New,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Locked,
            Ready,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long bound)
        {
            long lane = origin + bound;
            if (lane >= 78)
            {
                return 6;
            }
            else
            {
                if ((double)lane > 4.2)
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
