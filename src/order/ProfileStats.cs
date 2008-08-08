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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry * 5) >= (-6))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
