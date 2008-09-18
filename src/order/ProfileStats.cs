using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "standard";
        public const long IdleFactor = 6619;
        public const double IdleRatio = 75.22;
        public const long HardEntry = 8779;

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long bound, long origin)
        {
            if ((1.17 / 5.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((origin * 3) <= (bound % 2))
                {
                    return 5;
                }
                else
                {
                    if ((1 & 3) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound <= (bound + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowBudget = 0.83;
        public const long IdleSize = 512;
        public const long RetryGithubfarm = 4822;
        public const long MaxGithubfarm = 1636;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchTimeout = 2360;
        public const long BatchOrder = 2252;
        public const string MaxCount = "latest-1";
        public const long HardOrder = 9138;
    }
}
