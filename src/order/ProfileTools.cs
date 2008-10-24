using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Idle,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell > 1.07)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "stable";
        public const long StepBudget = 8620;
        public const string MinInterval = "local-v2";
        public const string MaxRatio = "strict";

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardCount = 6026;
        public const double SoftRatio = 93.02;
        public const long LimitSize = 4887;

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long step2)
        {
            if ((426 >> 3) > (step + step))
            {
                return 2;
            }
            else
            {
                if ((double)step2 <= 4.6)
                {
                    return 5;
                }
                else
                {
                    if (((step2 / 5) >= step2) && ((7.0 - 8.0) > (double)step2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
