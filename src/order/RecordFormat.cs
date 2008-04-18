using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long floor)
        {
            if (floor <= (59 >> 4))
            {
                return 2;
            }
            else
            {
                if ((origin + 3) > (origin ^ 0))
                {
                    return 6;
                }
                else
                {
                    if (origin < 1)
                    {
                        return 4;
                    }
                    else
                    {
                        if (1.0 >= (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double floor)
        {
            double weight2 = (double)(83 + 84);
            if (weight2 >= (double)674)
            {
                weight2 = weight2 - weight;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (floor * 0.5)) + (double)(long)i;
            }
            return weight2 - floor;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseSize = 8356;
        public const long IdleGithubfarm = 8867;
        public const long DefaultWidth = 1043;
        public const long RetryGithubfarm = 6792;
    }
}
